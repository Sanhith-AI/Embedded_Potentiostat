#include "stm32f303xe.h"
#include "User_Function.h"
#include "Peripheral_Initial.h"
#include "main.h"
#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include "arm_math.h"

extern uint8_t *UARTTemp;
extern UART_HandleTypeDef huart4;
extern UART_HandleTypeDef huart5;
extern SPI_HandleTypeDef hspi3;
//char f_read_Temp[32];
extern int32_t f_read[5000];
 int16_t CV1_ADC_Index=0;
 int32_t adc1_read[CV_ADC_Avg_Sample];
 //uint32_t count=0;
 float real_filtered_data[500];
 float real_reverse_filtered_data[500];
 float imaginary_filtered_data[500];
 float imaginary_reverse_filtered_data[500];
void LED_Off_GPIO_SetHigh(GPIO_TypeDef * GPIOx, uint16_t GPIO_Pin)
{
  //GPIOD->ODR |= GPIO_Pin;  // Set High
  GPIOx->BSRR = GPIO_Pin; // Set High
}

void LED_On_GPIO_SetLow(GPIO_TypeDef * GPIOx, uint16_t GPIO_Pin)
{
  GPIOx->BSRR = GPIO_Pin<<16u; // Set Low
  //GPIOx->ODR &=~ GPIO_Pin; //  Set Low
}

void LED_GPIO_Toggle(GPIO_TypeDef * GPIOx, uint16_t GPIO_Pin)
{
  GPIOx->ODR ^= GPIO_Pin;  // Toggle PD12,13,14,15
}

void CV_Flag_Var_Init()
{
  CVFlag.Start=1;
  CVFlag.RestTime=0;
  CVFlag.Busy = 0;
  CVFlag.Scan = 0;

  CVPar.Estep =CVT.estep*1000 ;  //10
  CVPar.ScanRate=CVT.scanrate*1000;  //100 for DVP
  CVPar.Estart = CVT.estart;
  CVPar.Estop = CVT.estop;

  /*CVPar.Estep =10 ;  //10
  CVPar.ScanRate=100;  //100 for DVP
  CVPar.Estart = -0.4;
  CVPar.Estop = 0.7;*/


  CVPar.SWVFreq = SWVT.frequency;
  CVPar.SWVAmp = SWVT.amplitude*1000; // in mv 200

 /* CVPar.SWVFreq = 10;
  CVPar.SWVAmp = 200; // in mv 200*/

  SWVFlag.Start = 1;
  SWVFlag.RestTime = 0;

  CVPar.DVPPulseON= DPVT.Tpulse*1000;
  CVPar.DPVAmp=DPVT.amplitude*1000 ;
  DPVFlag.Start=1;
  DPVFlag.RestTime = 0;
}

void CV_Var_Calculations(float Ebegin,float Eend,float Estp, float ScnRt)
{
 Estp/=1000;
 ScnRt/=1000;
 float DigitalEstep;
 uint8_t Temp;
 DigitalEstep = (Estp*4095)/(3.3);
 Temp = (uint8_t) (DigitalEstep);
 if((DigitalEstep-Temp)>0.5) Temp +=1;

 CVVar.DigitalEstep = Temp;
 CVPar.Estart = Ebegin + 1.5;
 CVPar.Estop = Eend + 1.5;
 CVVar.DigitalEstart = (CVPar.Estart/3.3)*4095;
 CVVar.DigitalEstop = (CVPar.Estop/3.3)*4095;

 CVVar.NumPoints = ((CVVar.DigitalEstop - CVVar.DigitalEstart)/(CVVar.DigitalEstep))+1;
 CVVar.TotalPoints = 2*CVVar.NumPoints;
 CVVar.TimefromEstartToEstop = (float) ((Eend - Ebegin)/(ScnRt));
 CVVar.TimePerPoint = CVVar.TimefromEstartToEstop/CVVar.NumPoints;
 CVVar.Tim4Value =  (CVVar.TimePerPoint *(CV_TIM_Clk/CV_TIM4_PS)) - 1;
 CVVar.TimeFor100Samples = (CVVar.TimePerPoint*95.0/100)/CV_ADC_Avg_Sample;
 CVVar.ADCTim2Value =  ((CVVar.TimeFor100Samples*CV_TIM_Clk)-1);
}
void CV_Start()
{
  if(CVFlag.Start)
  {
	CV_Var_Calculations(CVPar.Estart,CVPar.Estop,CVPar.Estep,CVPar.ScanRate);
	CVFlag.Start=0;
	CVFlag.Increment=1;
	CV_Dual_DAC_Init(CVVar.DigitalEstart-CVVar.DigitalEstep,1865, CV_TIM4_PS-1, CVVar.Tim4Value);
	CV_Single_ADC_Init(ADC_CHANNEL__1, ADC_1_CLOCK_CYCLE_5, 0, CVVar.ADCTim2Value , CVVar.ADC_Read);
	NVIC_EnableIRQ(TIM4_IRQn);
	NVIC_EnableIRQ(ADC1_IRQn);
	HAL_Delay(5000);                        // Starting Rest Time in msec.
	CVFlag.Scan = 1;
	TIM4->CR1 |= 0x01;						// Enable TIM4
  }
  if(CVFlag.RestTime)
  {
	HAL_Delay(1);
	CVFlag.Scan = 1;
	CVFlag.RestTime = 0;
	TIM4->CR1 |= 0x01;						// Enable TIM4
  }
}

void SWV_Var_Calculations(float Ebegin,float Eend,float Estp, uint16_t Freq, float Amp)
{
 Amp /= 1000; // in v
 CVVar.SWV_DAC_LowerLimit = (uint16_t) 1865-(4095*Amp/(3.3*2));
 CVVar.SWC_DAC_UpperLimit = (uint16_t) 1865+(4095*Amp/(3.3*2));
 Estp/=1000;
 float DigitalEstep;
 uint8_t Temp;
 DigitalEstep = (Estp*4095)/(3.3);
 Temp = (uint8_t) (DigitalEstep);
 if((DigitalEstep-Temp)>0.5) Temp +=1;

 CVVar.DigitalEstep = Temp;
 CVPar.Estart = Ebegin + 1.5;
 CVPar.Estop = Eend + 1.5;
 CVVar.DigitalEstart = CVPar.Estart/3.3*4095;
 CVVar.DigitalEstop = CVPar.Estop/3.3*4095;

 CVVar.NumPoints = ((CVVar.DigitalEstop - CVVar.DigitalEstart)/(CVVar.DigitalEstep))+1;
 CVVar.TotalPoints = 2*CVVar.NumPoints;
 float t_5pr=0; float t_half_SWV=0; uint16_t TempFreq=0;
 TempFreq= Freq*2;
 t_half_SWV = (float) 1/TempFreq;
 CVVar.Tim4Value =  (CV_TIM_Clk / (Freq*2*(CV_TIM4_PS)))-1;

 t_5pr =  (0.05*t_half_SWV);
 CVVar.TimePerPoint = (float) (t_5pr/(CV_ADC_Avg_Sample-5));
 float f_adc_ARR = CV_TIM_Clk * CVVar.TimePerPoint * (95.0/100);
 CVVar.ADCTim2Value = (uint32_t)f_adc_ARR;
 if(f_adc_ARR - CVVar.ADCTim2Value > 0.5) CVVar.ADCTim2Value++;
 CVVar.SWV_ADCSamples = (uint16_t)(t_half_SWV/CVVar.TimePerPoint);
}
void SWV_Start()
{
  if(SWVFlag.Start)
  {
	SWV_Var_Calculations(CVPar.Estart,CVPar.Estop,CVPar.Estep,CVPar.SWVFreq,CVPar.SWVAmp); //CVPar.SWVFreq
	SWVFlag.Start=0;
	CV_Dual_DAC_Init(CVVar.DigitalEstart-CVVar.DigitalEstep,CVVar.DigitalEstart, CV_TIM4_PS-1, CVVar.Tim4Value);
	CV_Single_ADC_Init(ADC_CHANNEL__1, ADC_1_CLOCK_CYCLE_5, 0, CVVar.ADCTim2Value-1, CVVar.ADC_Read);
	NVIC_EnableIRQ(TIM4_IRQn);
	NVIC_EnableIRQ(ADC1_IRQn);
	HAL_Delay(5000);                        // Starting Rest Time in msec.
	SWVFlag.Scan = 1;
	TIM4->CR1 |= 0x01;						// Enable TIM4
  }
  if(SWVFlag.RestTime)
  {
	HAL_Delay(1);
	SWVFlag.Scan = 1;
	SWVFlag.RestTime = 0;
	TIM4->CR1 |= 0x01;						// Enable TIM4
  }
}

/*void Uart_Transmission()
{
	if(CVFlag.Busy || SWVFlag.Busy)
	{
	    //UART4->CR1|=0x08;
		UART5->CR1|=0x08;
		char f_read_Temp[40];
		UARTTemp = (uint8_t *)f_read_Temp;
		uint32_t len=0;
		do{
			sprintf(f_read_Temp, "%ld\n%ld\n%ld\n%ld\n%ld\n%ld\n%ld\n%ld\n%ld\n%ld\n", f_read[len], f_read[len+1], f_read[len+2], f_read[len+3], f_read[len+4], f_read[len+5], f_read[len+6], f_read[len+7],f_read[len+8],f_read[len+9]);
			//HAL_UART_Transmit(&huart4, (uint8_t *)f_read_Temp, strlen(f_read_Temp), 1000);
			HAL_UART_Transmit(&huart5, (uint8_t *)f_read_Temp, strlen(f_read_Temp), 1000);
		/*	for(int i=0;i<40;i++)
			{
			 UART4->TDR =  (*UARTTemp++);
			 HAL_Delay(5);
			 while(!(UART4->ISR & 0x040));
			 HAL_Delay(10);
			}
			len=len+10;
			//UARTTemp = (uint8_t *)f_read_Temp;
			  /*UART5->TDR =  (*UARTTemp++);
			  HAL_Delay(50);
			  while(!(UART5->ISR & 0x040));
			  HAL_Delay(10);
			  len++;

		   }while(len<=CVVar.CV_SWV_Len);
		 CVVar.CV_SWV_Len=0;
		 CVFlag.Busy=0;
		 SWVFlag.Busy=0;
		 IWDG->KR = 0xCCCC;				// Enable watchdog
		 IWDG->KR = 0x5555;				// Enable access to pre scaler and reload register
		   	// t = 1/flsi * PR * RLR = 1/32x10^3 x 16 x (4095+1)
		 IWDG->PR = 0; //0x02;				// Write pre scaler 0x02 = divide/16
		 IWDG->RLR = 5;				// Write 12 bit reload register
		 while(IWDG->SR != 0x00) ;		// Wait for PR and RLR register to be written
		 IWDG->KR = 0xCCCC;				// Start watchdog
		 IWDG->KR = 0xAAAA;
		 IWDG->KR = 0;
		 DAC1->DHR12R1 = CVVar.DigitalEstart-CVVar.DigitalEstep;
		 CVFlag.Scan = 1;
		 TIM4->CR1 |=0x01;
	 }
}*/

void EIS_FIR_filter(float *real, float *imaginary, int length_data)
{

int count=0;
	for(int i=1;i<length_data;i++)
	{
		real_filtered_data[0]= 0.5*real[0];
		real_filtered_data[i] = 0.5*real[i] + 0.5*real[i-1];

		imaginary_filtered_data[0]= 0.5*imaginary[0];
		imaginary_filtered_data[i] = 0.5*imaginary[i] + 0.5*imaginary[i-1];
		count=count+1;
	}
	for(int j=0;j<length_data;j=j+1)
		{
			real_reverse_filtered_data[j] = real_filtered_data[count];
			imaginary_reverse_filtered_data[j] = imaginary_filtered_data[count];
			count=count-1;

		}
	count=0;
	for(int i=1;i<length_data;i++)
		{
			real_filtered_data[0]= real_reverse_filtered_data[0];
			real_filtered_data[i] = 0.5*real_reverse_filtered_data[i] + 0.5*real_reverse_filtered_data[i-1];

			imaginary_filtered_data[0]= imaginary_reverse_filtered_data[0];
			imaginary_filtered_data[i] = 0.5*imaginary_reverse_filtered_data[i] + 0.5*imaginary_reverse_filtered_data[i-1];

			count=count+1;
		}
	for(int i=0;i<length_data;i++)
			{
				real_reverse_filtered_data[i] = real_filtered_data[count];
				imaginary_reverse_filtered_data[i] = imaginary_filtered_data[count];
				count=count-1;

			}
	count=0;
	for(int i=1;i<length_data;i++)
		{
			real_filtered_data[0]= 0.5*real_reverse_filtered_data[0];
			real_filtered_data[i] = 0.5*real_reverse_filtered_data[i] + 0.5*real_reverse_filtered_data[i-1];

			imaginary_filtered_data[0]= imaginary_reverse_filtered_data[0];
			imaginary_filtered_data[i] = 0.5*imaginary_reverse_filtered_data[i] + 0.5*imaginary_reverse_filtered_data[i-1];

			count=count+1;
		}
	for(int i=0;i<length_data;i++)
				{
					real_reverse_filtered_data[i] = real_filtered_data[count];
					imaginary_reverse_filtered_data[i] = imaginary_filtered_data[count];
					count=count-1;

				}
	count=0;
	for(int i=1;i<length_data;i++)
		{
			real_filtered_data[0]= real_reverse_filtered_data[0];
			real_filtered_data[i] = 0.5*real_reverse_filtered_data[i] + 0.5*real_reverse_filtered_data[i-1];

			imaginary_filtered_data[0]= imaginary_reverse_filtered_data[0];
			imaginary_filtered_data[i] = 0.5*imaginary_reverse_filtered_data[i] + 0.5*imaginary_reverse_filtered_data[i-1];

			count=count+1;
		}
	for(int i=0;i<length_data;i++)
			{
				real_reverse_filtered_data[i] = real_filtered_data[count];
				imaginary_reverse_filtered_data[i] = imaginary_filtered_data[count];
				count=count-1;
			}
}

// Impedance Spectroscopy //

extern uint16_t Frequency_List[IS_MaxNoOfSineFreq];
extern float Frequency_List1[IS_MaxNoOfSineFreq];
//uint16_t Frequency_List[IS_MaxNoOfSineFreq] = {10000,0,2,5,10,25,50,75,100,150,200,250,300,400,500,600,750,1000,1500,2000,2500,3000,5000,6000,7500,9000,10000,0,15000,18000,25000,0};
//float Frequency_List1[IS_MaxNoOfSineFreq] = {10,0,2,5,10,25,50,75,100,150,200,250,300,400,500,600,750,1000,1500,2000,2500,3000,5000,6000,7500,9000,10000,15000,18000,25000,0};
//int random_count=0;
 uint16_t Sine_Lut[DAC_SineSample];
uint16_t DCPtnl_array[IS_MaxNoOfSineFreq];
uint8_t DCPtnl_Count=0, Freq_Count=0;
uint16_t *DC_List;
uint16_t IS_Prescaler = 1;
uint32_t IS_ADC_Read[IS_NoOfSamples];
uint16_t IS_ADC1[IS_NoOfSamples];
uint16_t IS_ADC2[IS_NoOfSamples];
uint16_t IS_Result_Count=0;
uint8_t sendingData[30];
uint16_t DFTCount=0;
uint16_t IS_Result1_Count=0;
//int Count=0;
uint32_t random_count=0;
uint8_t switching_value;
uint8_t cv;
extern uint8_t IS_default_switch_value;
float real_filter[25];
float imag_filter[25];
uint16_t filt_count=0;
uint16_t sine_amplitude;
float input_voltage;
/*#define Low_DAC_RANGE 1.815
#define High_DAC_RANGE 1.815
#define DAC_STEP  0.02 */


void Sin_Gen()
{
	// generate Look Up Table
  	for (int i=0; i< DAC_SineSample; i++)
  	{
  		input_voltage=(IST.eac/1000);
  		input_voltage=input_voltage*2*sqrt(2);
  	  sine_amplitude=(uint16_t)((input_voltage*4095)/(3.3));
  	  Sine_Lut[i] = (uint16_t)((sine_amplitude*sinf(((2*PI)/DAC_SineSample)*i))+1865); //  0.5sinwt  + 1.65
  	}
}
void adc_timer_update(uint32_t alias_freq)
{
	float a = alias_freq*IS_NoOfSamples;
	a = (CV_TIM_Clk/(IS_Prescaler))/a;
	a = a*IS_NoOfPeriods;
	TIM2->ARR = (uint32_t)(a-1);
	//TIM2->CR1 |= 0x01;
//	TIM2->ARR = (uint32_t)((RCC_FREQ/(alias_freq*n_samples))*n_period)-1;
}
void dac_timer_update(uint32_t freq)
{
	TIM4->ARR = (uint16_t)((CV_TIM_Clk/(IS_Prescaler*DAC_SineSample*freq))-1);			// Update dac timer value for new frequency
	TIM4->CR1 |= 0x01;									// counter enable
}
void IS_Var_Calculations(float Ebegin,float Eend,float Estp)
{
 Estp/=1000;
 CVVar.NumPoints = ((Eend - Ebegin)/Estp)+1;
 CVPar.Estart = Ebegin + 1.5;
 CVPar.Estop = Eend + 1.5;
 CVVar.DigitalEstart = CVPar.Estart/3.3*4095;
 CVVar.DigitalEstop = CVPar.Estop/3.3*4095;

 float DigitalEstep;
 uint8_t Temp;
 DigitalEstep = (Estp*4095)/(3.3);
 Temp = (uint8_t) (DigitalEstep);
 if((DigitalEstep-Temp)>0.5) Temp +=1;
 CVVar.DigitalEstep = Temp;

 ////// Populate Arrays for DC Potential ////////////////////////
 //DC_List_Adress = (float *) malloc(CVVar.NumPoints * sizeof(float));
 //DC_List = DC_List_Adress;
 DC_List = (uint16_t *)  malloc((CVVar.NumPoints+1) * sizeof(uint16_t));
 (*DC_List) = (uint16_t) CVVar.DigitalEstart;
 int DFTCount_i;
 for( DFTCount_i=0; DFTCount_i<101; DFTCount_i++)
 {
  if(Frequency_List[DFTCount_i] == 0) break;
 }
 DFTCount=DFTCount_i*CVVar.NumPoints;
 if(CVVar.NumPoints>1)
 {
  for(int i=1;i<CVVar.NumPoints;i++)        // DC_List[i] = DC_List[i-1] + CVVar.DigitalEstep;
  {
	  //DC_List_Adress++;
	  //DC_List = DC_List_Adress;
	  //float *Temp;
	 // Temp = DC_List_Adress-4;
	  uint16_t TempVal;
	  TempVal = *DC_List;
	  DC_List = DC_List+2;
	  (*DC_List) = (TempVal) + CVVar.DigitalEstep;
  }
 }
 DC_List = DC_List - ((CVVar.NumPoints-1) * sizeof(uint16_t));
 for(int i=0;i<IS_MaxNoOfSineFreq;i++)DCPtnl_array[i] =  *(DC_List + DCPtnl_Count);
 if(DCPtnl_Count < CVVar.NumPoints)DCPtnl_Count++;
 if(Frequency_List[Freq_Count]<=40)
 {
   IS_Prescaler=72;
 }
 CVVar.ADCTim2Value = (uint32_t)((CV_TIM_Clk/(IS_Prescaler*Frequency_List[0]*IS_NoOfSamples))*IS_NoOfPeriods)-1;
 CVVar.Tim4Value=(CV_TIM_Clk/(IS_Prescaler*DAC_SineSample*Frequency_List[Freq_Count]))-1;

////////////////////////////////////////////////////////////////
}
void IS_Start()
{
 IS_Var_Calculations(0,0,5);
 ISFlag.Scan =1;
 Sin_Gen();
 IS_Dual_DAC_Init(IS_Prescaler-1, CVVar.Tim4Value, Sine_Lut, DCPtnl_array);
 TIM4->CR1 |= 0x01;									// counter enable
 HAL_Delay(2500);
 IS_Dual_ADC_Init(ADC_CHANNEL__3, ADC_CHANNEL__3, ADC_1_CLOCK_CYCLE_5, IS_Prescaler-1,0, IS_ADC_Read);
 adc_timer_update(Frequency_List[Freq_Count++]);

 TIM2->CR1 |= 0x01;
}

struct DFT_Result compute_dft(uint16_t *ReadVolt_Freq1, uint16_t* ReadCurr_Freq1, uint8_t period, uint16_t NSamples)
{
	float VRef = 3.3;
	int16_t MaxAmp = 4095;
	struct DFT_Result results;

	float RealSum_Volt_Freq1 = 0;
	float RealSum_Curr_Freq1 = 0;
	float ImgSum_Volt_Freq1 = 0;
	float ImgSum_Curr_Freq1 = 0;
	for(uint16_t n=0; n<NSamples; n++)
	{
		float TempCos, TempSin;
		TempCos = arm_cos_f32(2*PI*n*period/NSamples);
		TempSin = arm_sin_f32(2*PI*n*period/NSamples);

		float RealPart_Volt_Freq1 = (float) ReadVolt_Freq1[n] * TempCos;
		float RealPart_Curr_Freq1 = (float) ReadCurr_Freq1[n] * TempCos;
		float ImgPart_Volt_Freq1 = -(float) ReadVolt_Freq1[n] * TempSin;
		float ImgPart_Curr_Freq1 = -(float) ReadCurr_Freq1[n] * TempSin;

		RealSum_Volt_Freq1 += (RealPart_Volt_Freq1*2/NSamples)*VRef/MaxAmp;
		RealSum_Curr_Freq1 += (RealPart_Curr_Freq1*2/NSamples)*VRef/MaxAmp;

		ImgSum_Volt_Freq1 += (ImgPart_Volt_Freq1*2/NSamples)*VRef/MaxAmp;
		ImgSum_Curr_Freq1 += (ImgPart_Curr_Freq1*2/NSamples)*VRef/MaxAmp;
	}
	//volatile float ab = sqrt((RealSum_Volt_Freq1*RealSum_Volt_Freq1)+(ImgSum_Volt_Freq1*ImgSum_Volt_Freq1));
	//volatile float abc = sqrt((RealSum_Curr_Freq1*RealSum_Curr_Freq1)+(ImgSum_Curr_Freq1*ImgSum_Curr_Freq1));

	float div = (RealSum_Curr_Freq1*RealSum_Curr_Freq1) + (ImgSum_Curr_Freq1*ImgSum_Curr_Freq1);
	/*
	 *  		RvRc + IvIc
	 * zreal = 	-------------
	 *  		Rc*Rc + Ic*Ic
	 */
	float zreal = ((RealSum_Volt_Freq1*RealSum_Curr_Freq1) + (ImgSum_Volt_Freq1*ImgSum_Curr_Freq1)) / div;
	/*
	 * 			IvRc - RvIc
	 * zimg =  ---------------
	 * 			Rc*Rc + Ic*Ic
	 */
	float zimag = ((ImgSum_Volt_Freq1*RealSum_Curr_Freq1) - (RealSum_Volt_Freq1*ImgSum_Curr_Freq1)) / div;

	//sprintf((char*)sendingData,"%f %f %f \n",zreal,zimag,Frequency_List1[random_count++]);
	//HAL_UART_Transmit(&huart5, sendingData, strlen((char*)sendingData),30);
	float zabs = 1*sqrt(zreal*zreal+zimag*zimag);
	float zphase = atan(zimag/zreal);
	float out_volt;
	out_volt=input_voltage/zabs;
	if(out_volt>=1.5)
	{
		CVFlag.gain_adjustment=1;
			  Freq_Count = Freq_Count-1;
			 IS_Result_Count=IS_Result_Count-1;
			 filt_count=filt_count-1;
			 if(IS_default_switch_value==0x04)
			 {
				 IS_default_switch_value=0x02;
			 }
			 else if(IS_default_switch_value==0x02)
			 {
				 IS_default_switch_value=0x01;
			 }

	}
	else
	{
		CVFlag.gain_adjustment=0;

	}
	if(IS_default_switch_value==0x04)
				 {
		zreal=zreal*10000;
		zimag=zimag*10000;
		real_filter[filt_count]=zreal;
		imag_filter[filt_count]=zimag;
		filt_count=filt_count+1;
				 }
	else if(IS_default_switch_value==0x02)
	{
		zreal=zreal*5000;
		zimag=zimag*5000;
		real_filter[filt_count]=zreal;
		imag_filter[filt_count]=zimag;
		filt_count=filt_count+1;
	}
	else
	{
		zreal=zreal*1000;
		zimag=zimag*1000;
		real_filter[filt_count]=zreal;
		imag_filter[filt_count]=zimag;
		filt_count=filt_count+1;
	}
	results.zab = zabs;
	results.zphase = zphase*180/PI;
	return results;
}

/*struct DLA_Result compute_fft(uint16_t *ReadVolt_Freq1, uint16_t* ReadCurr_Freq1, uint16_t Signal_Freq, uint16_t NSamples)
{
	float VRef = 3.3;
	int16_t MaxAmp = 4095;
	struct DLA_Result results1;
	float fs = 20*Signal_Freq;
	float Ts= 1/fs;
	float In_V_Out[NSamples/2],Qad_V_Out[NSamples/2],In_I_Out[NSamples/2],Qad_I_Out[NSamples/2];
	float TempCos[NSamples/2], TempSin[NSamples/2];
    float V_In[NSamples/2], V_Qad[NSamples/2],I_In[NSamples/2], I_Qad[NSamples/2];
   float RealSum_In_Volt_Freq1[NSamples/2];
	float RealSum_In_Curr_Freq1 [NSamples/2];
	float ImgSum_In_Volt_Freq1 [NSamples/2];
	float ImgSum_In_Curr_Freq1 [NSamples/2];
	float RealSum_Qad_Volt_Freq1 [NSamples/2];
	float RealSum_Qad_Curr_Freq1 [NSamples/2];
	float ImgSum_Qad_Volt_Freq1 [NSamples/2];
	float ImgSum_Qad_Curr_Freq1 [NSamples/2];
	float in1=0;
	float in2=0;
	float in3=0;
	float in4=0;
	float in5=0;
	float in6=0;
	float in7=0;
	float in8=0;
	float bv[500],bv1[500];
	float fft_real_filter_coeff[500]={1,0.95095,0.80865,0.58722,0.30852,5.5756e-17,-0.30807,-0.5856,-0.8056,-0.94673,-0.99534,-0.94673,-0.80559,-0.58558,-0.30805,-1.3723e-16,0.30844,0.58702,0.80832,0.95048,0.99948,0.95049,0.80837,0.58715,0.3086,5.2532e-16,-0.3085,-0.58681,-0.80779,-0.94979,-0.99878,-0.94972,-0.80727,-0.58553,-0.3069,1.104e-16,0.30323,0.57098,0.77529,0.89544,0.92069,0.85173,0.7006,0.48902,0.24524,3.0566e-16,-0.21795,-0.38575,-0.48938,-0.52492,-0.49817,-0.42271,-0.31687,-0.20019,-0.090217,-9.0828e-17,0.063169,0.097835,0.10737,0.098265,0.078256,0.054555,0.032674,0.015864,0.0051809,-8.8072e-16,-0.0012566,-0.00040317,0.0010414,0.0021255,0.002487,0.002202,0.0015624,0.0008743,0.00033467,7.7057e-16,-0.00017569,-0.00027323,-0.00035049,-0.00041762,-0.00044793,-0.00040987,-0.00029869,-0.00014993,-2.859e-05,-8.456e-16,-9.7655e-05,-0.00030376,-0.00055224,-0.00075358,-0.000831,-0.0007527,-0.00054636,-0.00028974,-8.0887e-05,1.1309e-15,-7.8073e-05,-0.00028483,-0.00054059,-0.0007472,-0.00082595,-0.00074751,-0.00054259,-0.00028944,-8.3319e-05,-1.0942e-15,-6.7308e-05,-0.00025545,-0.00048942,-0.00067833,-0.00075021,-0.00067883,-0.00049269,-0.00026308,-7.6133e-05,2.9656e-16,-5.9429e-05,-0.00022741,-0.00043654,-0.00060539,-0.00066962,-0.00060586,-0.00043965,-0.00023467,-6.7848e-05,-9.2502e-16,-5.3221e-05,-0.0002034,-0.00039034,-0.0005413,-0.00059873,-0.0005417,-0.000393,-0.0002096,-6.0419e-05,-9.8441e-16,-4.8232e-05,-0.00018354,-0.00035187,-0.00048783,-0.00053958,-0.00048817,-0.00035407,-0.00018867,-5.4183e-05,6.908e-16,-4.4194e-05,-0.0001673,-0.00032036,-0.000444,-0.00049107,-0.00044427,-0.00032215,-0.00017149,-4.9058e-05,-1.1247e-15,-4.0918e-05,-0.00015407,-0.00029468,-0.00040827,-0.00045154,-0.00040849,-0.00029614,-0.00015749,-4.4877e-05,-3.9218e-16,-3.8263e-05,-0.00014334,-0.00027381,-0.00037924,-0.00041941,-0.00037942,-0.000275,-0.0001461,-4.1474e-05,-9.5382e-17,-3.612e-05,-0.00013465,-0.00025692,-0.00035574,-0.00039341,-0.00035589,-0.00025788,-0.00013688,-3.8711e-05,1.3094e-15,-3.4407e-05,-0.00012767,-0.00024335,-0.00033685,-0.0003725,-0.00033697,-0.00024411,-0.00012946,-3.6478e-05,-1.44e-15,-3.3062e-05,-0.00012215,-0.00023258,-0.00032186,-0.00035591,-0.00032195,-0.00023318,-0.00012356,-3.469e-05,1.3118e-15,-3.2039e-05,-0.00011788,-0.00022424,-0.00031023,-0.00034304,-0.0003103,-0.0002247,-0.00011895,-3.3281e-05,-3.5798e-16,-3.1304e-05,-0.00011473,-0.00021802,-0.00030156,-0.00033344,-0.00030161,-0.00021836,-0.0001155,-3.2202e-05,2.4799e-16,-3.0834e-05,-0.00011257,-0.00021374,-0.00029556,-0.0003268,-0.00029559,-0.00021395,-0.00011308,-3.1416e-05,-1.5154e-15,-3.0612e-05,-0.00011136,-0.00021124,-0.00029204,-0.00032289,-0.00029206,-0.00021135,-0.0001116,-3.0899e-05,1.6491e-15,-3.0634e-05,-0.00011104,-0.00021045,-0.00029088,-0.00032161,-0.00029088,-0.00021045,-0.00011104,-3.0634e-05,3.5729e-15,-3.0899e-05,-0.0001116,-0.00021135,-0.00029206,-0.00032289,-0.00029204,-0.00021124,-0.00011136,-3.0612e-05,8.0255e-16,-3.1416e-05,-0.00011308,-0.00021395,-0.00029559,-0.0003268,-0.00029556,-0.00021374,-0.00011257,-3.0834e-05,-1.1849e-15,-3.2202e-05,-0.0001155,-0.00021836,-0.00030161,-0.00033344,-0.00030156,-0.00021802,-0.00011473,-3.1304e-05,2.2007e-15,-3.3281e-05,-0.00011895,-0.0002247,-0.0003103,-0.00034304,-0.00031023,-0.00022424,-0.00011788,-3.2039e-05,-9.6567e-16,-3.469e-05,-0.00012356,-0.00023318,-0.00032195,-0.00035591,-0.00032186,-0.00023258,-0.00012215,-3.3062e-05,1.336e-16,-3.6478e-05,-0.00012946,-0.00024411,-0.00033697,-0.0003725,-0.00033685,-0.00024335,-0.00012767,-3.4407e-05,1.5095e-15,-3.8711e-05,-0.00013688,-0.00025788,-0.00035589,-0.00039341,-0.00035574,-0.00025692,-0.00013465,-3.612e-05,-2.917e-15,-4.1474e-05,-0.0001461,-0.000275,-0.00037942,-0.00041941,-0.00037924,-0.00027381,-0.00014334,-3.8263e-05,-8.4863e-16,-4.4877e-05,-0.00015749,-0.00029614,-0.00040849,-0.00045154,-0.00040827,-0.00029468,-0.00015407,-4.0918e-05,-4.2459e-15,-4.9058e-05,-0.00017149,-0.00032215,-0.00044427,-0.00049107,-0.000444,-0.00032036,-0.0001673,-4.4194e-05,-9.8188e-16,-5.4183e-05,-0.00018867,-0.00035407,-0.00048817,-0.00053958,-0.00048783,-0.00035187,-0.00018354,-4.8232e-05,-3.2806e-15,-6.0419e-05,-0.0002096,-0.000393,-0.0005417,-0.00059873,-0.0005413,-0.00039034,-0.0002034,-5.3221e-05,1.967e-15,-6.7848e-05,-0.00023467,-0.00043965,-0.00060586,-0.00066962,-0.00060539,-0.00043654,-0.00022741,-5.9429e-05,-7.0312e-15,-7.6133e-05,-0.00026308,-0.00049269,-0.00067883,-0.00075021,-0.00067833,-0.00048942,-0.00025545,-6.7308e-05,3.0137e-15,-8.3319e-05,-0.00028944,-0.00054259,-0.00074751,-0.00082595,-0.0007472,-0.00054059,-0.00028483,-7.8073e-05,-5.9885e-15,-8.0887e-05,-0.00028974,-0.00054636,-0.0007527,-0.000831,-0.00075358,-0.00055224,-0.00030376,-9.7655e-05,8.6688e-15,-2.859e-05,-0.00014993,-0.00029869,-0.00040987,-0.00044793,-0.00041762,-0.00035049,-0.00027323,-0.00017569,-3.1542e-15,0.00033467,0.0008743,0.0015624,0.002202,0.002487,0.0021255,0.0010414,-0.00040317,-0.0012566,4.358e-15,0.0051809,0.015864,0.032674,0.054555,0.078256,0.098265,0.10737,0.097835,0.063169,-7.0514e-15,-0.090217,-0.20019,-0.31687,-0.42271,-0.49817,-0.52492,-0.48938,-0.38575,-0.21795,-1.0057e-15,0.24524,0.48902,0.7006,0.85173,0.92069,0.89544,0.77529,0.57098,0.30323,4.8786e-15,-0.3069,-0.58553,-0.80727,-0.94972,-0.99878,-0.94979,-0.80779,-0.58681,-0.3085,-9.1016e-15,0.3086,0.58715,0.80837,0.95049,0.99948,0.95048,0.80832,0.58702,0.30844,1.4994e-14,-0.30805,-0.58558,-0.80559,-0.94673,-0.99534,-0.94673,-0.8056,-0.5856,-0.30807,2.5026e-16,0.30852,0.58722,0.80865,0.95095};
	float fft_imag_filter_coeff[500]={0,-0.30898,-0.58752,-0.80823,-0.94951,-0.99766,-0.94814,-0.80601,-0.5853,-0.30761,-1.0509e-16,0.30761,0.5853,0.80599,0.94807,0.99751,0.94929,0.80797,0.58728,0.30883,1.4832e-16,-0.30883,-0.58732,-0.80815,-0.94977,-0.99842,-0.94945,-0.80767,-0.58689,-0.30861,-3.0303e-16,0.30858,0.58651,0.80591,0.94454,0.98835,0.93324,0.78589,0.56328,0.29095,9.4271e-17,-0.27674,-0.50902,-0.67307,-0.75478,-0.75126,-0.67077,-0.53094,-0.35556,-0.17056,-4.8426e-16,0.13735,0.23022,0.27554,0.27766,0.24638,0.19442,0.13466,0.078005,0.031928,-2.6281e-16,-0.017726,-0.023739,-0.021834,-0.015945,-0.0092767,-0.0038673,-0.00055492,0.0007566,0.0006906,1.4112e-15,-0.00071548,-0.0011352,-0.0012034,-0.00103,-0.00077122,-0.00054071,-0.00037607,-0.00025464,-0.00013569,-6.773e-16,0.00013318,0.00021701,0.00020637,8.7991e-05,-0.00010478,-0.00030055,-0.00041809,-0.00040123,-0.00024485,9.0943e-16,0.00024457,0.00039696,0.00039879,0.00024894,4.6794e-06,-0.00024028,-0.00039204,-0.00039276,-0.00024278,-1.3547e-15,0.00024288,0.00039421,0.00039838,0.00025643,2.4793e-05,-0.00020715,-0.00035159,-0.00035558,-0.0002204,1.5608e-15,0.00022057,0.00035796,0.00036209,0.00023431,2.5804e-05,-0.0001829,-0.000313,-0.00031716,-0.0001967,-1.0128e-15,0.00019686,0.00031943,0.000323,0.00020881,2.2582e-05,-0.0001638,-0.00027995,-0.0002836,-0.00017588,3.76e-16,0.00017601,0.00028553,0.00028849,0.00018595,1.8812e-05,-0.00014844,-0.00025262,-0.00025565,-0.00015851,-1.5902e-15,0.00015862,0.00025725,0.00025968,0.00016676,1.5417e-05,-0.00013602,-0.00023026,-0.00023275,-0.00014426,1.3473e-15,0.00014435,0.00023406,0.00023603,0.00015099,1.2563e-05,-0.00012593,-0.00021207,-0.00021409,-0.00013266,-2.085e-15,0.00013273,0.00021516,0.00021676,0.00013812,1.0208e-05,-0.00011776,-0.00019729,-0.00019893,-0.00012322,-1.6325e-15,0.00012328,0.0001998,0.0002011,0.00012764,8.2642e-06,-0.00011116,-0.00018533,-0.00018666,-0.00011559,6.232e-16,0.00011563,0.00018736,0.0001884,0.00011914,6.6437e-06,-0.00010589,-0.00017573,-0.0001768,-0.00010945,-5.5939e-16,0.00010949,0.00017736,0.00017819,0.00011227,5.2728e-06,-0.00010175,-0.00016813,-0.00016898,-0.00010458,1.1842e-15,0.00010461,0.00016942,0.00017006,0.00010676,4.0914e-06,-9.8607e-05,-0.00016225,-0.00016292,-0.0001008,-1.0316e-15,0.00010082,0.00016325,0.00016373,0.00010243,3.051e-06,-9.6344e-05,-0.00015791,-0.0001584,-9.7983e-05,6.3133e-16,9.7999e-05,0.00015864,0.00015897,9.9107e-05,2.1119e-06,-9.4896e-05,-0.00015494,-0.00015529,-9.6034e-05,-2.306e-15,9.6044e-05,0.00015545,0.00015563,9.669e-05,1.241e-06,-9.4215e-05,-0.00015327,-0.00015347,-9.4889e-05,4.5962e-15,9.4895e-05,0.00015355,0.00015361,9.5098e-05,4.0938e-07,-9.4282e-05,-0.00015283,-0.0001529,-9.4514e-05,-3.4794e-16,9.4514e-05,0.0001529,0.00015283,9.4282e-05,-4.0938e-07,-9.5098e-05,-0.00015361,-0.00015355,-9.4895e-05,1.8343e-15,9.4889e-05,0.00015347,0.00015327,9.4215e-05,-1.241e-06,-9.669e-05,-0.00015563,-0.00015545,-9.6044e-05,1.2788e-16,9.6034e-05,0.00015529,0.00015494,9.4896e-05,-2.1119e-06,-9.9107e-05,-0.00015897,-0.00015864,-9.7999e-05,9.6765e-16,9.7983e-05,0.0001584,0.00015791,9.6344e-05,-3.051e-06,-0.00010243,-0.00016373,-0.00016325,-0.00010082,-1.8481e-15,0.0001008,0.00016292,0.00016225,9.8607e-05,-4.0914e-06,-0.00010676,-0.00017006,-0.00016942,-0.00010461,5.8737e-16,0.00010458,0.00016898,0.00016813,0.00010175,-5.2728e-06,-0.00011227,-0.00017819,-0.00017736,-0.00010949,-2.3373e-15,0.00010945,0.0001768,0.00017573,0.00010589,-6.6437e-06,-0.00011914,-0.0001884,-0.00018736,-0.00011563,-2.6867e-15,0.00011559,0.00018666,0.00018533,0.00011116,-8.2642e-06,-0.00012764,-0.0002011,-0.0001998,-0.00012328,-6.1041e-17,0.00012322,0.00019893,0.00019729,0.00011776,-1.0208e-05,-0.00013812,-0.00021676,-0.00021516,-0.00013273,1.1473e-15,0.00013266,0.00021409,0.00021207,0.00012593,-1.2563e-05,-0.00015099,-0.00023603,-0.00023406,-0.00014435,2.0051e-15,0.00014426,0.00023275,0.00023026,0.00013602,-1.5417e-05,-0.00016676,-0.00025968,-0.00025725,-0.00015862,-1.4854e-15,0.00015851,0.00025565,0.00025262,0.00014844,-1.8812e-05,-0.00018595,-0.00028849,-0.00028553,-0.00017601,1.0137e-15,0.00017588,0.0002836,0.00027995,0.0001638,-2.2582e-05,-0.00020881,-0.000323,-0.00031943,-0.00019686,-3.788e-15,0.0001967,0.00031716,0.000313,0.0001829,-2.5804e-05,-0.00023431,-0.00036209,-0.00035796,-0.00022057,5.2327e-15,0.0002204,0.00035558,0.00035159,0.00020715,-2.4793e-05,-0.00025643,-0.00039838,-0.00039421,-0.00024288,-5.396e-15,0.00024278,0.00039276,0.00039204,0.00024028,-4.6794e-06,-0.00024894,-0.00039879,-0.00039696,-0.00024457,-1.833e-15,0.00024485,0.00040123,0.00041809,0.00030055,0.00010478,-8.7991e-05,-0.00020637,-0.00021701,-0.00013318,-7.567e-15,0.00013569,0.00025464,0.00037607,0.00054071,0.00077122,0.00103,0.0012034,0.0011352,0.00071548,1.0326e-14,-0.0006906,-0.0007566,0.00055492,0.0038673,0.0092767,0.015945,0.021834,0.023739,0.017726,-3.618e-16,-0.031928,-0.078005,-0.13466,-0.19442,-0.24638,-0.27766,-0.27554,-0.23022,-0.13735,-1.4887e-15,0.17056,0.35556,0.53094,0.67077,0.75126,0.75478,0.67307,0.50902,0.27674,6.2559e-15,-0.29095,-0.56328,-0.78589,-0.93324,-0.98835,-0.94454,-0.80591,-0.58651,-0.30858,-4.3691e-15,0.30861,0.58689,0.80767,0.94945,0.99842,0.94977,0.80815,0.58732,0.30883,4.2983e-15,-0.30883,-0.58728,-0.80797,-0.94929,-0.99751,-0.94807,-0.80599,-0.5853,-0.30761,-1.0875e-14,0.30761,0.5853,0.80601,0.94814,0.99766,0.94951,0.80823,0.58752,0.30898};
	for(uint16_t m=0; m<NSamples/2; m++)
	{
		TempSin[m] = 0.65*arm_sin_f32(2*PI*m*Ts*Signal_Freq);
		TempCos[m] = 0.65*arm_cos_f32(2*PI*m*Ts*Signal_Freq);
		 bv[m]=((float) ReadVolt_Freq1[m]/MaxAmp)*VRef;
		 bv1[m]=((float) ReadCurr_Freq1[m]/MaxAmp)*VRef;

		V_In[m]=TempSin[m]*bv[m];
		V_Qad[m]=TempCos[m]*bv[m];
		I_In[m]=TempSin[m]*bv1[m];
		I_Qad[m]=TempCos[m]*bv1[m];

	}

for (uint16_t k=0;k<NSamples/2;k++)
{
	for (uint16_t p=0;p<NSamples/2;p++)
		{
		float TempCos, TempSin;
		TempCos = arm_cos_f32((2*PI*(p)*(k))/(NSamples/2));
		TempSin = arm_sin_f32((2*PI*(p)*(k))/(NSamples/2));
		float interm1=  V_In[p] * TempCos;
		float interm2= I_In[p] *TempCos ;
		float interm3= V_Qad[p] *TempCos ;
		float interm4= I_Qad[p] * TempCos;
		float interm5= (-V_In[p]) * TempSin;
		float interm6= (-I_In[p]) * TempSin;
		float interm7= (-V_Qad[p])  *TempSin;
		float interm8= (-I_Qad[p]) * TempSin;
		in1=in1+interm1;
		in2=in2+interm2;
		in3=in3+interm3;
		in4=in4+interm4;
		in5=in5+interm5;
		in6=in6+interm6;
		in7=in7+interm7;
		in8=in8+interm8;
		}
	RealSum_In_Volt_Freq1[k]=in1;
	RealSum_In_Curr_Freq1[k]=in2;
	RealSum_Qad_Volt_Freq1 [k]=in3;
	RealSum_Qad_Curr_Freq1 [k]=in4;
	ImgSum_In_Volt_Freq1 [k]=in5;
	ImgSum_In_Curr_Freq1 [k]=in6;
	ImgSum_Qad_Volt_Freq1 [k]=in7;
	ImgSum_Qad_Curr_Freq1 [k]=in8;
	In_V_Out[k] = RealSum_In_Volt_Freq1[k]*fft_real_filter_coeff[k]+RealSum_In_Volt_Freq1[k]*fft_imag_filter_coeff[k]+ImgSum_In_Volt_Freq1 [k]*fft_real_filter_coeff[k]+ImgSum_In_Volt_Freq1 [k]*fft_imag_filter_coeff[k];
	Qad_V_Out[k] = RealSum_Qad_Volt_Freq1[k]*fft_real_filter_coeff[k]+RealSum_Qad_Volt_Freq1[k]*fft_imag_filter_coeff[k]+ImgSum_Qad_Volt_Freq1 [k]*fft_real_filter_coeff[k]+ImgSum_Qad_Volt_Freq1 [k]*fft_imag_filter_coeff[k];
	In_I_Out[k] = RealSum_In_Curr_Freq1[k]*fft_real_filter_coeff[k]+RealSum_In_Curr_Freq1[k]*fft_imag_filter_coeff[k]+ImgSum_In_Curr_Freq1 [k]*fft_real_filter_coeff[k]+ImgSum_In_Curr_Freq1 [k]*fft_imag_filter_coeff[k];
	Qad_I_Out[k] = RealSum_Qad_Curr_Freq1[k]*fft_real_filter_coeff[k]+RealSum_Qad_Curr_Freq1[k]*fft_imag_filter_coeff[k]+ImgSum_Qad_Curr_Freq1 [k]*fft_real_filter_coeff[k]+ImgSum_Qad_Curr_Freq1 [k]*fft_imag_filter_coeff[k];

	in1=0;
	in2=0;
	in3=0;
	in4=0;
	in5=0;
	in6=0;
	in7=0;
	in8=0;
}
	 In_V_Out[0] = RealSum_In_Volt_Freq1[0]*fft_real_filter_coeff[0];
	Qad_V_Out[0] = RealSum_Qad_Volt_Freq1[0]*fft_real_filter_coeff[0];
	In_I_Out[0] = RealSum_In_Curr_Freq1[0]*fft_real_filter_coeff[0];
	Qad_I_Out[0] =RealSum_Qad_Curr_Freq1[0]*fft_real_filter_coeff[0];

float Mag_V=sqrt(In_V_Out[0]*In_V_Out[0]+Qad_V_Out[0]*Qad_V_Out[0]);
float Phase_V=atan(Qad_V_Out[0]/ In_V_Out[0]);
float Mag_I=sqrt(In_I_Out[0]*In_I_Out[0]+Qad_I_Out[0]*Qad_I_Out[0]);
float Phase_I=atan(Qad_I_Out[0]/In_I_Out[0]);

	float zabs = Mag_V/Mag_I;
	float zphase = Phase_V - Phase_I;
	//sprintf((char*)sendingData,"%f %f %f \n",zabs,zphase,Frequency_List1[random_count++]);
		//HAL_UART_Transmit(&huart5, sendingData, strlen((char*)sendingData),30);
	results1.zab = zabs;
	results1.zphase = zphase*(180/PI);
	return results1;
}*/
char f_read_Temp[80];
void IS_Complete()
{
	if(ISFlag.RestTime)
	{
		  for(uint16_t i=0; i<IS_NoOfSamples; i++)
		  {
			  IS_ADC2[i] = (uint16_t) (IS_ADC_Read[i] >> 16);
			  IS_ADC1[i] = IS_ADC_Read[i] & 0x0000FFFF;
		  }

		  IS_Results[IS_Result_Count++]= compute_dft(IS_ADC1, IS_ADC2, IS_NoOfPeriods, IS_NoOfSamples);
		  //IS_Results1[IS_Result1_Count++]=compute_fft(IS_ADC1, IS_ADC2,Frequency_List[Count] , IS_NoOfSamples);
		  //Count=Count+1;

		  //sprintf(f_read_Temp, "%3.4f, %3.4f\n\r", IS_Results[IS_Result_Count-1].zab, IS_Results[IS_Result_Count-1].zphase);
		  //HAL_UART_Transmit(&huart4, (uint8_t *)f_read_Temp, strlen(f_read_Temp), 1000);
		  //HAL_UART_Transmit(&huart4, (uint8_t *)aTXBuffer, strlen(aTXBuffer), 1000);
		  //HAL_Delay(2500);
		  if(Frequency_List[Freq_Count] != 0)
		  {
			  if(Frequency_List[Freq_Count]>40)
			  {
			    IS_Prescaler=1;
			    TIM4->PSC = IS_Prescaler-1;
			    TIM2->PSC = IS_Prescaler-1;
			  }
			  if(CVFlag.gain_adjustment)
			  {



			HAL_GPIO_WritePin(GPIOD, GPIO_PIN_10, GPIO_PIN_RESET);

				  HAL_SPI_Transmit(&hspi3,&IS_default_switch_value,1,100);

				  HAL_GPIO_WritePin(GPIOD, GPIO_PIN_10, GPIO_PIN_SET);

			  }
			  dac_timer_update(Frequency_List[Freq_Count]);
			  //TIM4->CR1 |= 0x01;
			  HAL_Delay(2500);
			  adc_timer_update(Frequency_List[Freq_Count++]);
			  TIM2->CR1 |= 0x01;	// Enable TIM2 (ADC)

		  }
		  else
		  {
			  if(filt_count==1)
			  {
				  real_reverse_filtered_data[0] = real_filter[0];
				  imaginary_reverse_filtered_data[0]=imag_filter[0];
			  }
			  else
			  {
				  EIS_FIR_filter(real_filter,imag_filter,filt_count);
				  real_reverse_filtered_data[0] = real_filter[0];
				  imaginary_reverse_filtered_data[0]=imag_filter[0];
			  }
for(int i=0;i<filt_count;i++)
{
			  sprintf((char*)sendingData,"%f %f %f \n",real_reverse_filtered_data[i],imaginary_reverse_filtered_data[i],Frequency_List1[i]);
			  HAL_UART_Transmit(&huart5, sendingData, strlen((char*)sendingData),30);
}
 			  Freq_Count = 0;
 			random_count=0;
 			filt_count=0;
 			//Count=0;
			  IS_Result_Count=0;
			  //IS_Result1_Count=0;
			  if(Frequency_List[Freq_Count]>40)
			  {
			  	IS_Prescaler=1;
			  	TIM4->PSC = IS_Prescaler-1;
			  	TIM2->PSC = IS_Prescaler-1;
			  }
			  else
			  {
				  IS_Prescaler=72;
				  TIM4->PSC = IS_Prescaler-1;
				  TIM2->PSC = IS_Prescaler-1;
			  }
		/*	  if(DCPtnl_Count < CVVar.NumPoints)
			  {
				  int len = sizeof(DCPtnl_array)/sizeof(DCPtnl_array[0]);
				  for(int i=0; i<len; i++)																		// Populate dac_list
				  {
				   DCPtnl_array[i] = (uint16_t) (*(DC_List+ 2*DCPtnl_Count));
				  }
				   DCPtnl_Count++;
		      }
			  else
			  {
			    DCPtnl_Count = 0;
			    DC_List = DC_List - ((CVVar.NumPoints-1) * sizeof(uint16_t));
			    int len = sizeof(DCPtnl_array)/sizeof(DCPtnl_array[0]);
				  for(int i=0; i<len; i++)																		// Populate dac_list
				  {
				   DCPtnl_array[i] = (uint16_t) (*(DC_List+DCPtnl_Count));
				  }
				   DCPtnl_Count++;
			   }*/
			 // IS_Dual_DAC_Init(IS_Prescaler-1, CVVar.Tim4Value, Sine_Lut, DCPtnl_array);
			  for(int i=0; i<20; i++)																		// Populate dac_list
			  {
				  IS_Results[i].zab = 0;
				  IS_Results[i].zphase=0;

			  }
			 // IS_Dual_ADC_Init(ADC_CHANNEL__3, ADC_CHANNEL__3, ADC_1_CLOCK_CYCLE_5, IS_Prescaler-1,0, IS_ADC_Read);
			  dac_timer_update(Frequency_List[Freq_Count]);
			  HAL_Delay(5);
			  adc_timer_update(Frequency_List[Freq_Count++]);
			  TIM2->CNT = 0;
			 // NVIC_EnableIRQ(ADC1_IRQn);
			  TIM2->CR1 |= 0x01;								// Enable TIM2 (ADC)
		  }

		  ISFlag.RestTime = 0;

	  }
}

////// DPV ////////
uint16_t DPV_Off_ADCSamples;
uint16_t DPV_On_ADCSamples;
//uint16_t DPV_Total_ADCSamples;
//uint32_t DPV_Total_ADCVal;
//float t_5pr;
float TimePerPoint;
float DVP_TimeInterval;
float DVPPulseOff;
void DPV_Var_Calculations(float TPulse,float Ebegin,float Eend,float Estp,float ScnRate)
{
 TPulse /= 1000;
 Estp /=1000;
 ScnRate /=1000;
 DVP_TimeInterval = (Estp/ScnRate);
 float Amp= CVPar.DPVAmp / 1000; // in v
 CVVar.SWV_DAC_LowerLimit = (uint16_t) (1865-(4095*Amp/(3.3*2)));
 CVVar.SWC_DAC_UpperLimit = (uint16_t) (1865+(4095*Amp/(3.3*2)));
 DVPPulseOff = DVP_TimeInterval - TPulse;

 uint16_t DVP_Freq = (uint16_t)(1/DVP_TimeInterval);
 uint16_t DVP_Freq1=(uint16_t)(1/DVPPulseOff);
 uint16_t DVP_Freq2= (uint16_t)(1/TPulse); //for duty cycle selection for pulse

 //CVPar.SWVFreq = (uint16_t) DVP_Freq;
 float DigitalEstep;
 uint8_t Temp;
 DigitalEstep = (Estp*4095)/(3.3);
 Temp = (uint8_t) (DigitalEstep);
 if((DigitalEstep-Temp)>0.5) Temp +=1;
 CVVar.DigitalEstep = Temp;

 CVPar.Estart = Ebegin + 1.5;
 CVPar.Estop = Eend + 1.5;
 CVVar.DigitalEstart = CVPar.Estart/3.3*4095;
 CVVar.DigitalEstop = CVPar.Estop/3.3*4095;
 CVVar.NumPoints = ((CVVar.DigitalEstop - CVVar.DigitalEstart)/CVVar.DigitalEstep)+1;
 CVVar.TotalPoints = 2*CVVar.NumPoints;
 CVVar.Tim4Value = (uint16_t) ((CV_TIM_Clk/(DVP_Freq1*2*CV_TIM4_PS))-1);     // Prescaler fixed at 7199, for Timer 3 and Timer 4 both same
 //CVVar.duty=(uint32_t)((DVPPulseOff/DVP_TimeInterval)*CVVar.Tim4Value);
 //CVVar.duty1=(uint32_t)((TPulse/DVP_TimeInterval)*CVVar.Tim4Value);
 //CVVar.TimePerPoint = (TPulse/DVP_TimeInterval);						 // CCR value for timer 3 to decide duty cycle
 CVVar.Tim41Value=(uint16_t) ((CV_TIM_Clk/(DVP_Freq2*2*CV_TIM4_PS))-1);
 // Fix Timer 4 Value for DAC at 10 us, no need of timer 3
 float t_5pr=0; float t_half_DPV=0; uint16_t TempFreq=0;
 TempFreq= DVP_Freq1*2;
 t_half_DPV = (float) 1/TempFreq;

 t_5pr = (0.05* t_half_DPV);

 TimePerPoint= (float) (t_5pr/(CV_ADC_Avg_Sample-5));
 float f_adc_ARR;
 f_adc_ARR = (CV_TIM_Clk) * TimePerPoint  * (95.0/100);
 CVVar.ADCTim2Value = (uint32_t)f_adc_ARR;
 if(f_adc_ARR - CVVar.ADCTim2Value > 0.5) CVVar.ADCTim2Value++;
 DPV_Off_ADCSamples = (uint16_t)(t_half_DPV/TimePerPoint);


 TempFreq= DVP_Freq2*2;
 t_half_DPV = (float) 1/TempFreq;

 t_5pr = (0.05* t_half_DPV);

 TimePerPoint= (float) (t_5pr/(CV_ADC_Avg_Sample-5));
 float f_adc_ARR1;
 f_adc_ARR1 = (CV_TIM_Clk) * TimePerPoint  * (95.0/100);
 CVVar.ADCTim21Value = (uint32_t)f_adc_ARR1;
 if(f_adc_ARR1 - CVVar.ADCTim2Value > 0.5) CVVar.ADCTim2Value++;
 DPV_On_ADCSamples = (uint16_t)(t_half_DPV/TimePerPoint);
 /*TempFreq= DVP_Freq1;
 t_half_DPV = (float) 1/TempFreq;

 t_5pr = 0.05*t_half_DPV ;

 TimePerPoint = t_5pr/(CV_ADC_Avg_Sample-5);
 f_adc_ARR = (CV_TIM_Clk) * TimePerPoint * (95.0/100);
 CVVar.ADCTim21Value = (uint32_t)f_adc_ARR;
 if(f_adc_ARR - CVVar.ADCTim21Value > 0.5) CVVar.ADCTim21Value++;
 DPV_On_ADCSamples = (uint32_t)(t_half_DPV/TimePerPoint);;*/

 //t_5pr = 0.05*DVPPulseOff;
 //TimePerPoint = t_5pr/(CV_ADC_Avg_Sample-5);
 //f_adc_ARR = (CV_TIM_Clk) * TimePerPoint * (95.0/100);
 //DPV_Off_ADCVal = (uint32_t)f_adc_ARR;
 //if(f_adc_ARR - DPV_Off_ADCVal > 0.5) DPV_Off_ADCVal++;
 //DPV_Off_ADCSamples = (uint16_t)(DVPPulseOff/TimePerPoint);


 /*t_5pr = 0.05*DVP_TimeInterval;
 TimePerPoint = t_5pr/(CV_ADC_Avg_Sample-5);
 f_adc_ARR = (CV_TIM_Clk) * TimePerPoint * (95.0/100);
 DPV_Total_ADCVal = (uint32_t)f_adc_ARR;
 if(f_adc_ARR - DPV_Off_ADCVal > 0.5) DPV_Total_ADCVal++;
 DPV_Total_ADCSamples = (uint16_t)(DVP_TimeInterval/TimePerPoint);*/

}


void DPV_Start()
{
	if(DPVFlag.Start)
	  {
		DPV_Var_Calculations(CVPar.DVPPulseON,CVPar.Estart,CVPar.Estop,CVPar.Estep,CVPar.ScanRate);
		DPVFlag.Start=0;
		DPV_Timer3_DAC_Init(CVVar.DigitalEstart-CVVar.DigitalEstep,CVVar.DigitalEstart,CV_TIM4_PS,CVVar.Tim4Value);
		CV_Single_ADC_Init(ADC_CHANNEL__1, ADC_1_CLOCK_CYCLE_5, 0, CVVar.ADCTim2Value-1, CVVar.ADC_Read);
		NVIC_EnableIRQ(TIM4_IRQn);
		NVIC_EnableIRQ(ADC1_IRQn);
		HAL_Delay(5000);                        // Starting Rest Time in msec.
		DPVFlag.Scan = 1;
		TIM4->CR1 |= 0x01;

	  }
}
