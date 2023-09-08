/*
 * User_Function.h
 *
 *  Created on: Aug 29, 2020
 *      Author: Rohan
 */

#ifndef APPLICATION_USER_USER_FUNCTION_H_
#define APPLICATION_USER_USER_FUNCTION_H_
#include "stm32f303xe.h"
#include "arm_math.h"
#define CV_ADC_Avg_Sample 405
#define CV_TIM_Clk 72000000
#define CV_TIM4_PS 720

// Impedance Spectroscopy Functions //

#define DAC_SineSample 32
#define IS_MaxNoOfSineFreq 101
#define IS_NoOfSamples 1000
#define IS_NoOfPeriods (IS_NoOfSamples/20)

/* // CV Formulas  //
 * NumberOfPoints = (Estop - Estart)/Estep
 * TotalPoints = 2*NumberOfPoints
 * TimefromEstartToEstop = (Estop - Estart)/ScanRate
 * uint16_t DigitalEstep = (Estep/1000)/(3.3/4095)
 * TimeFor1Point = TimefromEstartToEstop/NumberOfPoints
 * Timer4Value = TimeFor1Point * 72MHz -1;
 * TimeFor100Samplesin1Point = (TimeFor1Point-(1/1000))/100;
 * ADCTimerTime = TimeFor100Samplesin1Point * 72MHz -1;
 * SWV Formulas ///////////////////
 * float t_half_SWV = 1/(Freq_SWV*2);
 * float t_5pr = 0.05*t_half_SWV;
 * float t_1_adc_sample = t_5pr/100;
 * float f_adc_ARR = RCC_CLOCK * t_1_adc_sample * (95/100); //98.61
 * uint32_t adc_ARR = (uint32_t)f_adc_ARR;
 * if(f_adc_ARR - adc_ARR > 0.5)
 * adc_ARR++;
 * adc_samples = (uint16_t)(t_half_SWV/t_1_adc_sample);
 * uint16_t dac_ARR = (RCC_CLOCK / (Freq_SWV*2*(pre_dac_time+1)))-1;
 */
struct CVUserParameters
{
	float Estart;
	float Estop;
	float Estep;
	float ScanRate;
	uint16_t SWVFreq;
	float SWVAmp;
	float DVPPulseON;
	float DPVAmp;
};
struct CVUserParameters CVPar;

struct CVTransmit
{
	float estart;
	float estop;
	float estep;
	float scanrate;
	int current;
	int noofscans;
};
struct CVTransmit CVT;

struct SWVTransmit
{
	int current;
	float amplitude;
	float frequency;
};
struct SWVTransmit SWVT;

struct DPVTransmit
{
	float amplitude;
	float Tpulse;
};
struct DPVTransmit DPVT;

struct ISTransmit
{
	float edc;
	float eac;
	int current;
	float min_frequency;
	float max_frequency;
	float frequency;
};
struct ISTransmit IST;



struct CVVariables
{
	uint32_t NumPoints;
	uint32_t TotalPoints;
	float TimefromEstartToEstop;
	uint16_t DigitalEstep;
	float TimePerPoint;
	uint16_t Tim4Value;
	uint16_t Tim41Value;
	float TimeFor100Samples;
	uint32_t ADCTim2Value;
	uint32_t ADCTim21Value;
	uint32_t duty;
	uint32_t duty1;
	int16_t DigitalEstart;
	int16_t DigitalEstop;
	int32_t ADC_Read[CV_ADC_Avg_Sample];
    uint16_t SWV_ADCSamples;
    uint16_t SWV_DAC_LowerLimit;
    uint16_t SWC_DAC_UpperLimit;
    uint16_t CV_SWV_Len;
uint16_t Digital_DPV_Amplitude;
};
struct CVVariables CVVar;
struct CVVariableFlags
{
	uint8_t RestTime;
	uint8_t Start;
	uint8_t Busy;
	uint8_t Scan;
	uint8_t Increment;
	uint8_t Decrement;
	uint8_t gain_adjustment;

};

struct CVVariableFlags CVFlag;
struct CVVariableFlags SWVFlag;
struct CVVariableFlags ISFlag;
struct CVVariableFlags DPVFlag;

struct DFT_Result
{
 float zab;
 float zphase;
};
/*struct DLA_Result
{
 float zab;
 float zphase;
};*/

struct DFT_Result compute_dft(uint16_t *, uint16_t*, uint8_t, uint16_t);
//struct DLA_Result compute_fft(uint16_t *, uint16_t*, uint16_t, uint16_t);

 struct DFT_Result IS_Results[30];
// struct DLA_Result IS_Results1[30];

void LED_Off_GPIO_SetHigh(GPIO_TypeDef * GPIOx, uint16_t GPIO_Pin);
void LED_On_GPIO_SetLow(GPIO_TypeDef * GPIOx, uint16_t GPIO_Pin);
void LED_GPIO_Toggle(GPIO_TypeDef * GPIOx, uint16_t GPIO_Pin);

void CV_Flag_Var_Init(void);

void CV_Var_Calculations(float Ebegin,float Eend,float Estp, float ScnRt);
void CV_Start(void);

void SWV_Var_Calculations(float Ebegin,float Eend,float Estp, uint16_t Freq, float Amp);
void SWV_Start(void);

void IS_Var_Calculations(float Ebegin,float Eend,float Estp);
void IS_Start(void);
void IS_Complete(void);
void dac_timer_update(uint32_t freq);
void adc_timer_update(uint32_t alias_freq);
void Sin_Gen(void);

void DPV_Var_Calculations(float TPulse, float Ebegin,float Eend,float Estp,float ScnRate);
void DPV_Start(void);
void Uart_Transmission(void);

#endif /* APPLICATION_USER_USER_FUNCTION_H_ */
