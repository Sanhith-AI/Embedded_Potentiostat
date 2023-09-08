/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file    stm32f3xx_it.c
  * @brief   Interrupt Service Routines.
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2020 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
  */
/* USER CODE END Header */

/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "stm32f3xx_it.h"
/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "User_Function.h"
#include <string.h>
#include <stdio.h>
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN TD */
extern UART_HandleTypeDef huart4;
extern UART_HandleTypeDef huart5;
/* USER CODE END TD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
 
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
/* USER CODE BEGIN PV */

int32_t adc_read[CV_ADC_Avg_Sample];
int32_t f_read[5000];
int16_t CV_ADC_Index=0;
int32_t average = 0;
int32_t *f_read_ptr = f_read;
uint16_t CV_ADC_Volt[1000], CV_ADC_Volt_Count=0;
uint8_t sendingData[30];
extern uint32_t IS_ADC_Read[IS_NoOfSamples];
uint8_t IS_Sine_Count=0;
uint16_t IS_ADC_Count = 0;
int SWV_Count=0;
int SWV_Count1=0;
int SWV_Count2=0;
int CV_Count=0;
int CV_Count1=0;
int CV_Count2=0;
extern uint16_t DPV_On_ADCSamples;
extern uint16_t DPV_Off_ADCSamples;
float SWV_Currentval[500];
float CV_Currentval[500];
float CV_Voltageval[500];
float volta_filtered_data[500];
float volta_reverse_filtered_data[500];
int length_CV;
int length_SWV;
int length_DPV;

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
/* USER CODE BEGIN PFP */
void voltammetry_FIR_filter(float *current_response, int length_data)
{

int count=0;
	for(int i=1;i<length_data;i++)
	{
		volta_filtered_data[0]= 0.5*current_response[0];

		volta_filtered_data[i] = 0.5*current_response[i] + 0.5*current_response[i-1];
		count=count+1;
	}
	for(int j=0;j<length_data;j=j+1)
		{
			volta_reverse_filtered_data[j] = volta_filtered_data[count];
			count=count-1;

		}
	count=0;
	for(int i=1;i<length_data;i++)
		{
			volta_filtered_data[0]= volta_reverse_filtered_data[0];
			volta_filtered_data[i] = 0.5*volta_reverse_filtered_data[i] + 0.5*volta_reverse_filtered_data[i-1];
			count=count+1;
		}
	for(int i=0;i<length_data;i++)
			{
				volta_reverse_filtered_data[i] = volta_filtered_data[count];
				count=count-1;

			}
	count=0;
	for(int i=1;i<length_data;i++)
		{
			volta_filtered_data[0]= 0.5*volta_reverse_filtered_data[0];
			volta_filtered_data[i] = 0.5*volta_reverse_filtered_data[i] + 0.5*volta_reverse_filtered_data[i-1];
			count=count+1;
		}
	for(int i=0;i<length_data;i++)
				{
					volta_reverse_filtered_data[i] = volta_filtered_data[count];
					count=count-1;

				}
	count=0;
	for(int i=1;i<length_data;i++)
		{
			volta_filtered_data[0]= volta_reverse_filtered_data[0];
			volta_filtered_data[i] = 0.5*volta_reverse_filtered_data[i] + 0.5*volta_reverse_filtered_data[i-1];
			count=count+1;
		}
	for(int i=0;i<length_data;i++)
			{
				volta_reverse_filtered_data[i] = volta_filtered_data[count];
				count=count-1;
			}
}
/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
void TIM4_IRQHandler(void)
{
	if(TIM4->SR & 0x01)
	{
		///// CV /////
	 if(CVFlag.Scan)
	 {
		if(CVFlag.Increment)
		{
		 if(DAC1->DHR12R1 < CVVar.DigitalEstop)
		 {
			 CV_ADC_Volt[CV_ADC_Volt_Count] = DAC1->DHR12R1 + CVVar.DigitalEstep;
			 DAC1->DHR12R1 = CV_ADC_Volt[CV_ADC_Volt_Count];

							CV_ADC_Volt_Count++;

		 }

		 else
		 {
			CVFlag.Increment=0;
			CVFlag.Decrement=1;

		//	CVFlag.Scan=0;
		//	CVFlag.RestTime = 1;
		//	TIM4->CR1 &= ~0x01;					// Disable TIM4
		 }
		}
		if(CVFlag.Decrement)
		{
		 if(DAC1->DHR12R1 > CVVar.DigitalEstart)
		 {
			 CV_ADC_Volt[CV_ADC_Volt_Count] = DAC1->DHR12R1 - CVVar.DigitalEstep;
			 DAC1->DHR12R1 = CV_ADC_Volt[CV_ADC_Volt_Count];
			 //DAC1->DHR12R1 = DAC1->DHR12R1 - CVVar.DigitalEstep;  // step size
			 CV_ADC_Volt_Count++;

		 }


		 else
		 {
			 length_CV=(CVT.estop-CVT.estart)/(CVT.estep);
			 length_CV=length_CV*2;
				for(int i=0;i<length_CV;i=i+1)
				{
					float volt_trans=(((CV_ADC_Volt[i]*3.3)/4095)-1.5);
					float current_trans=(((f_read[i]*3.3)/4095)-1.5)/10;
					CV_Voltageval[i]=volt_trans;
					CV_Currentval[i]=current_trans;
			     }
				voltammetry_FIR_filter(CV_Currentval,length_CV);
			  	for(int i=0;i<length_CV;i=i+1)
			  		{
		  			 sprintf((char*)sendingData,"%f %f\n",CV_Voltageval[i],volta_reverse_filtered_data[i]);
		  			 HAL_UART_Transmit(&huart5, sendingData, strlen((char*)sendingData),100);
		  			 for(int j=0;j<500000;j++)
		  			 {}
			  		}

			CVFlag.Increment=1;
			CVFlag.Decrement = 0;
			CVFlag.Scan = 0;
			CVFlag.Busy = 1;  // UART On
			TIM4->CR1 &= ~0x01;	  // Disable TIM4


			*f_read_ptr = (int32_t) f_read;


		 }

	    }
		//LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);							// Toggle PB7
		//LED_GPIO_Toggle(GPIOE,GPIO_PIN_10);

		TIM2->CR1 |= 0x01;								// Enable TIM2
	  }
     ///// SWV /////
	else if(SWVFlag.Scan)
	 {
		TIM2->CR1 |= 0x01;	    // Enable TIM2
		SWVFlag.Decrement = 1; // For ADC valid_adc = 1;
		uint16_t dac1_1_v = 0xFFF & DAC1->DHR12RD;				// Get DAC input data for CH1
		uint16_t dac1_2_v = DAC1->DHR12RD >> 16;					// Get DAC input data for CH2
		 if(dac1_2_v >= CVVar.SWC_DAC_UpperLimit)
		 {
		 	DAC1->DHR12RD = (CVVar.SWV_DAC_LowerLimit << 16) + dac1_1_v;

		 	SWVFlag.Increment = 0;
		 }
		 else
		 {
		  	DAC1->DHR12RD = (CVVar.SWC_DAC_UpperLimit << 16) + dac1_1_v;
		  	SWVFlag.Increment = 1;
		 }
		 dac1_1_v = 0xFFF & DAC1->DHR12RD;
		 dac1_2_v = DAC1->DHR12RD >> 16;

		 if(SWVFlag.Increment)
		 {
		   if(dac1_1_v < CVVar.DigitalEstop)
		   DAC1->DHR12RD = (dac1_2_v << 16) + dac1_1_v + CVVar.DigitalEstep;   // 12 is for Estep
		   else
		   {
			  SWVFlag.Increment = 0;
			  length_SWV=(CVT.estop-CVT.estart)/(CVT.estep);
			  	for(int i=0;i<length_SWV;i=i+1)
			  			{
			  			float c1=f_read[2*i];
			  			float c2=f_read[2*i+1];
			  			float c3;
			  			c1=(1.5-(3.3/4095)*c1)/10;
			  			c2=(1.5-(3.3/4095)*c2)/10;
			  			if(c1>c2)
			  			{
			  				 c3=c1-c2;
			  			}
			  			else
			  			{
			  				 c3=c2-c1;
			  			}

			  			SWV_Currentval[i]=c3;

			  			 }
			  	voltammetry_FIR_filter(SWV_Currentval,length_SWV);
			  	float volt_SWV=CVT.estart;
			  	for(int i=0;i<length_SWV;i=i+1)
			  		{
		  			 sprintf((char*)sendingData,"%f %f\n",volt_SWV,volta_reverse_filtered_data[i]);
		  			 HAL_UART_Transmit(&huart5, sendingData, strlen((char*)sendingData),100);
		  			volt_SWV= volt_SWV+ CVT.estep;
		  			 for(int j=0;j<500000;j++)
		  			 {}
			  		}
		 	  TIM4->CR1 &= ~0x01;				// Disable TIM4
		 	  SWVFlag.Scan = 0;
		 	  SWVFlag.Busy = 1;

		 	}
		  }
		// LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);							// Toggle PB7
	 }

//////DPV //////

	else if(DPVFlag.Scan)
			 {

				DPVFlag.Decrement = 1; // For ADC valid_adc = 1;
				uint16_t dac1_1_v = 0xFFF & DAC1->DHR12RD;				// Get DAC input data for CH1
				uint16_t dac1_2_v = DAC1->DHR12RD >> 16;					// Get DAC input data for CH2
				 if(dac1_2_v >= CVVar.SWC_DAC_UpperLimit)
				 {

					TIM2->ARR= CVVar.ADCTim2Value;
					TIM2->CR1 |= 0x01;    // Enable TIM2
					CVVar.SWV_ADCSamples= DPV_Off_ADCSamples;
					TIM4->ARR= CVVar.Tim4Value;;
					TIM4->CR1 |= 0x01;
				 	DAC1->DHR12RD = (CVVar.SWV_DAC_LowerLimit << 16) + dac1_1_v;
				 	DPVFlag.Increment = 0;
				 }
				 else
				 {

					TIM2->ARR= CVVar.ADCTim21Value;
					TIM2->CR1 |= 0x01;    // Enable TIM2
					CVVar.SWV_ADCSamples= DPV_On_ADCSamples;
					TIM4->ARR= CVVar.Tim41Value;;
					TIM4->CR1 |= 0x01;
				  	DAC1->DHR12RD = (CVVar.SWC_DAC_UpperLimit << 16) + dac1_1_v;
				  	DPVFlag.Increment = 1;
				 }
				 dac1_1_v = 0xFFF & DAC1->DHR12RD;
				 dac1_2_v = DAC1->DHR12RD >> 16;
				 if(DPVFlag.Increment)
				 {
				   if(dac1_1_v < CVVar.DigitalEstop)
				   DAC1->DHR12RD = (dac1_2_v << 16) + dac1_1_v + CVVar.DigitalEstep;   // 12 is for Estep
				   else
				   {
						  length_DPV=(CVT.estop-CVT.estart)/(CVT.estep);
								  	for(int i=0;i<length_DPV;i=i+1)
								  			{
								  			float c1=f_read[2*i];
								  			float c2=f_read[2*i+1];
								  			float c3;
								  			c1=(1.5-(3.3/4095)*c1)/10;
								  			c2=(1.5-(3.3/4095)*c2)/10;
								  			if(c1>c2)
								  			{
								  				 c3=c1-c2;
								  			}
								  			else
								  			{
								  				 c3=c2-c1;
								  			}

								  			SWV_Currentval[i]=c3;
								  			 }
								  	voltammetry_FIR_filter(SWV_Currentval,length_DPV);
								  	float volt_DPV=CVT.estart;
								  	for(int i=0;i<length_DPV;i=i+1)
								  		{
							  			 sprintf((char*)sendingData,"%f %f\n",volt_DPV,volta_reverse_filtered_data[i]);
							  			 HAL_UART_Transmit(&huart5, sendingData, strlen((char*)sendingData),100);
							  			volt_DPV= volt_DPV+ CVT.estep;
							  			 for(int j=0;j<500000;j++)
							  			 {}
								  		}

					  DPVFlag.Increment = 0;
				 	  TIM4->CR1 &= ~0x01;				// Disable TIM4
				 	  DPVFlag.Scan = 0;
				 	  DPVFlag.Busy = 1;
				 	}
				  }
				// LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);							// Toggle PB7
			 }

     else
	 {	// To set first DAC value and wait for 5 sec
		TIM4->CR1 &= ~0x01;								// Disable TIM4
	 }

	 TIM4->SR &=~ 0x01;
	}

}
uint8_t DPVCount=0;
void TIM3_IRQHandler(void)
{
 //if(DPVCount>5)
 //{
	if(DAC1->DHR12R2 < CVVar.DigitalEstop)
	{
	 TIM4->CR1 &= ~0x01;
	 DAC1->DHR12R2 = DAC1->DHR12R2 + CVVar.DigitalEstep;
	 TIM4->CR1 |=0x01;
	 //DPVFlag.Increment = 1;
	 TIM2->CR1 |= 0x01;
	}
	else
	{
	 //DPVCount=0;
	  DAC1->DHR12R2=CVVar.DigitalEstart;
	 //TIM3->CR1 &= ~0x01;
	 //TIM2->CR1 &= ~0x01;
	}
 //}
 //LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);
 //DPVCount++;

 //DPVFlag.Decrement = 1;
 TIM3->SR &=~ 0x04;
}
void ADC1_IRQHandler(void)
{
	if(ADC1->ISR & 0x04)
	{
	  if(CVFlag.Scan)
	  {
		  if(CV_ADC_Index >= CV_ADC_Avg_Sample)
		  {
			TIM2->CR1 &= ~0x01;							// Disable TIM2
			CV_ADC_Index = 0;
			average = 0;
			for(int i=5;i<CV_ADC_Avg_Sample;i++) average += adc_read[i];
			*f_read_ptr = average/(CV_ADC_Avg_Sample-5);
			f_read_ptr++;
			CVVar.CV_SWV_Len++;
		  }
		  adc_read[CV_ADC_Index++] = ADC1->DR;
	  }

	 if(SWVFlag.Decrement)
	  {
	  		if(CV_ADC_Index >= CVVar.SWV_ADCSamples)
	  		{
	  			SWVFlag.Decrement = 0;
	  			CV_ADC_Index = 0;
	  			average = 0;
	  			for(int i=0; i<CV_ADC_Avg_Sample-5; i++)
	  			{
	  				average += adc_read[i];
	  			}
	  			*f_read_ptr = average/(CV_ADC_Avg_Sample-5);
	  			if(f_read_ptr < &f_read[4999])
	  			{
	  				f_read_ptr++;
	  				CVVar.CV_SWV_Len++;
	  			}
	  			else
	  			{
	  				*f_read_ptr = f_read;
	  			}
	  		}
	  		if(CV_ADC_Index >= (CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5) && CV_ADC_Index < CVVar.SWV_ADCSamples)
	  		{
	  			LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);
	  			adc_read[CV_ADC_Index-(CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5)] = ADC1->DR;
	  			CV_ADC_Index++;
	  		}
	  		else CV_ADC_Index++;
	  }

	  if(ISFlag.Scan)
	  {
		  if(IS_ADC_Count >= IS_NoOfSamples)
		  {
			  IS_ADC_Count = 0;
			  TIM4->CR1 &= ~0x01;
			  ISFlag.RestTime = 1;
			TIM2->CR1 &= ~0x01;							// Disable TIM2
			//NVIC_DisableIRQ(ADC1_IRQn);
		  }
		  else	IS_ADC_Read[IS_ADC_Count++] = ADC12_COMMON->CDR;
		  //ADC12_COMMON->CCR |=0x04;
		  ADC2->ISR |= 0x04;
	  }

	  if(DPVFlag.Decrement)
	  	  {
	  		if((CV_ADC_Index >= CVVar.SWV_ADCSamples))
	  		{
	  			 TIM2->CR1 &=~0x01;
	  			 CV_ADC_Index = 0;
	  			average = 0;
	  			for(int i=0; i<CV_ADC_Avg_Sample-5; i++)
	  			{
	  				average += adc_read[i];
	  			}
	  			*f_read_ptr = average/(CV_ADC_Avg_Sample-5);
	  			if(f_read_ptr < &f_read[4999])
	  			{
	  				f_read_ptr++;
	  			}
	  			else
	  			{
	  				*f_read_ptr = f_read;
	  			}


	  		 }

	  		     if(CV_ADC_Index >= (CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5) && CV_ADC_Index < CVVar.SWV_ADCSamples)
	  			 {

	  				LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);
	  				adc_read[CV_ADC_Index-(CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5)] = ADC1->DR;
	  				CV_ADC_Index++;
	  			 }
	  		  	 else
	  			 {
	  			  CV_ADC_Index++;
	  			 }
	  	   }


	  ADC1->ISR |= 0x04;								// Clear EOC flag
	}
}
/* USER CODE END 0 */

/* External variables --------------------------------------------------------*/

/* USER CODE BEGIN EV */

/* USER CODE END EV */

/******************************************************************************/
/*           Cortex-M4 Processor Interruption and Exception Handlers          */
/******************************************************************************/
/**
  * @brief This function handles Non maskable interrupt.
  */
void NMI_Handler(void)
{
  /* USER CODE BEGIN NonMaskableInt_IRQn 0 */

  /* USER CODE END NonMaskableInt_IRQn 0 */
  /* USER CODE BEGIN NonMaskableInt_IRQn 1 */

  /* USER CODE END NonMaskableInt_IRQn 1 */
}

/**
  * @brief This function handles Hard fault interrupt.
  */
void HardFault_Handler(void)
{
  /* USER CODE BEGIN HardFault_IRQn 0 */

  /* USER CODE END HardFault_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_HardFault_IRQn 0 */
    /* USER CODE END W1_HardFault_IRQn 0 */
  }
}

/**
  * @brief This function handles Memory management fault.
  */
void MemManage_Handler(void)
{
  /* USER CODE BEGIN MemoryManagement_IRQn 0 */

  /* USER CODE END MemoryManagement_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_MemoryManagement_IRQn 0 */
    /* USER CODE END W1_MemoryManagement_IRQn 0 */
  }
}

/**
  * @brief This function handles Pre-fetch fault, memory access fault.
  */
void BusFault_Handler(void)
{
  /* USER CODE BEGIN BusFault_IRQn 0 */

  /* USER CODE END BusFault_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_BusFault_IRQn 0 */
    /* USER CODE END W1_BusFault_IRQn 0 */
  }
}

/**
  * @brief This function handles Undefined instruction or illegal state.
  */
void UsageFault_Handler(void)
{
  /* USER CODE BEGIN UsageFault_IRQn 0 */

  /* USER CODE END UsageFault_IRQn 0 */
  while (1)
  {
    /* USER CODE BEGIN W1_UsageFault_IRQn 0 */
    /* USER CODE END W1_UsageFault_IRQn 0 */
  }
}

/**
  * @brief This function handles System service call via SWI instruction.
  */
void SVC_Handler(void)
{
  /* USER CODE BEGIN SVCall_IRQn 0 */

  /* USER CODE END SVCall_IRQn 0 */
  /* USER CODE BEGIN SVCall_IRQn 1 */

  /* USER CODE END SVCall_IRQn 1 */
}

/**
  * @brief This function handles Debug monitor.
  */
void DebugMon_Handler(void)
{
  /* USER CODE BEGIN DebugMonitor_IRQn 0 */

  /* USER CODE END DebugMonitor_IRQn 0 */
  /* USER CODE BEGIN DebugMonitor_IRQn 1 */

  /* USER CODE END DebugMonitor_IRQn 1 */
}

/**
  * @brief This function handles Pendable request for system service.
  */
void PendSV_Handler(void)
{
  /* USER CODE BEGIN PendSV_IRQn 0 */

  /* USER CODE END PendSV_IRQn 0 */
  /* USER CODE BEGIN PendSV_IRQn 1 */

  /* USER CODE END PendSV_IRQn 1 */
}

/**
  * @brief This function handles System tick timer.
  */
void SysTick_Handler(void)
{
  /* USER CODE BEGIN SysTick_IRQn 0 */

  /* USER CODE END SysTick_IRQn 0 */
  HAL_IncTick();
  /* USER CODE BEGIN SysTick_IRQn 1 */

  /* USER CODE END SysTick_IRQn 1 */
}

/******************************************************************************/
/* STM32F3xx Peripheral Interrupt Handlers                                    */
/* Add here the Interrupt Handlers for the used peripherals.                  */
/* For the available peripheral interrupt handler names,                      */
/* please refer to the startup file (startup_stm32f3xx.s).                    */
/******************************************************************************/

/* USER CODE BEGIN 1 */

////// DPV OLD LOGIC  ///////
/*if(CV_ADC_Index >= CVVar.SWV_ADCSamples)
		{
			TIM2->CR1 &=~ 0x01;
			CV_ADC_Index = 0;
			average = 0;
			for(int i=0; i<CV_ADC_Avg_Sample-5; i++)
			{
				average += adc_read[i];
			}
			*f_read_ptr = average/(CV_ADC_Avg_Sample-5);
			if(f_read_ptr < &f_read[4999])
			{
				f_read_ptr++;
				CVVar.CV_SWV_Len++;
			}
			else
			{
				*f_read_ptr = f_read;
			}
			TIM2->CNT=0;
			if(DPVFlag.Decrement)
			{
			  TIM3->CR1 &=~0x01;
			  DPVFlag.Decrement = 0;
			  TIM2->ARR = CVVar.ADCTim2Value-1;
			  TIM3->CR1 |=0x01;
			}
			if(DPVFlag.Increment)
			{
			  DPVFlag.Decrement =1;
			  DPVFlag.Increment = 0;
			  TIM2->ARR = DPV_Off_ADCVal-1;
			  TIM2->CR1 |=0x01;
			}
		 }
		 if(CV_ADC_Index >= (CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5) && CV_ADC_Index < CVVar.SWV_ADCSamples)
		 {
			LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);
			adc_read[CV_ADC_Index-(CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5)] = ADC1->DR;
			CV_ADC_Index++;
		 }
		 else CV_ADC_Index++;*/
		/*if(DPVFlag.Increment)
		{
			if(CV_ADC_Index >= CVVar.SWV_ADCSamples)
			{
				TIM2->CR1 &=~ 0x01;
				DPVFlag.Increment=0;
				CV_ADC_Index = 0;
				average = 0;
				for(int i=0; i<CV_ADC_Avg_Sample-5; i++)
				{
					average += adc_read[i];
				}
				*f_read_ptr = average/(CV_ADC_Avg_Sample-5);
				if(f_read_ptr < &f_read[4999])
				{
					f_read_ptr++;
					CVVar.CV_SWV_Len++;
				}
				else
				{
					*f_read_ptr = f_read;
				}
				TIM2->ARR = DPV_Off_ADCVal-1;
				DPVFlag.Decrement = 1;
				TIM2->CR1 |=0x01;
			 }
			 if(CV_ADC_Index >= (CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5) && CV_ADC_Index < CVVar.SWV_ADCSamples)
			 {
				LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);
				adc_read[CV_ADC_Index-(CVVar.SWV_ADCSamples-CV_ADC_Avg_Sample+5)] = ADC1->DR;
				CV_ADC_Index++;
			 }
			 else CV_ADC_Index++;
		 }

		if(DPVFlag.Decrement )
		{
			if(CV_ADC_Index >= DPV_Off_ADCSamples)
			{
				TIM2->CR1 &=~ 0x01;
				TIM3->CR1 &= ~0x01;
				DPVFlag.Decrement = 0;
				CV_ADC_Index = 0;
				average = 0;
				for(int i=0; i<CV_ADC_Avg_Sample-5; i++)
				{
					average += adc_read[i];
				}
				*f_read_ptr = average/(CV_ADC_Avg_Sample-5);
				if(f_read_ptr < &f_read[4999])
				{
					f_read_ptr++;
					CVVar.CV_SWV_Len++;
				}
				else
				{
					*f_read_ptr = f_read;
				}

				TIM2->ARR = CVVar.ADCTim2Value-1;
				TIM3->CR1 |=0x01;
			 }
			 if(CV_ADC_Index >= (DPV_Off_ADCSamples-CV_ADC_Avg_Sample+5) && CV_ADC_Index < DPV_Off_ADCSamples)
			 {
				LED_GPIO_Toggle(GPIOB,GPIO_PIN_7);
				adc_read[CV_ADC_Index-(DPV_Off_ADCSamples-CV_ADC_Avg_Sample+5)] = ADC1->DR;
				CV_ADC_Index++;
			 }
			 else CV_ADC_Index++;
		 }*/
/* USER CODE END 1 */

