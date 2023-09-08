/*
 * Peripheral_Initial.h
 *
 *  Created on: Aug 29, 2020
 *      Author: Rohan
 */

#ifndef APPLICATION_USER_PERIPHERAL_INITIAL_H_
#define APPLICATION_USER_PERIPHERAL_INITIAL_H_
#include "stm32f303xe.h"
typedef enum {
	DAC_CHANNEL__1 = 4,
	DAC_CHANNEL__2 = 5
}DAC1_Channel;
typedef enum {
	ADC_1_CLOCK_CYCLE_5 = 0x00,
	ADC_2_CLOCK_CYCLE_5 = 0x01,
	ADC_4_CLOCK_CYCLE_5 = 0x02,
	ADC_7_CLOCK_CYCLE_5 = 0x03,
	ADC_19_CLOCK_CYCLE_5 = 0x04,
	ADC_61_CLOCK_CYCLE_5 = 0x05,
	ADC_181_CLOCK_CYCLE_5 = 0x06,
	ADC_601_CLOCK_CYCLE_5 = 0x07
}Sample_Time;
typedef enum {
	ADC_CHANNEL__1 = 1,
	ADC_CHANNEL__2 = 2,
	ADC_CHANNEL__3 = 3,
	ADC_CHANNEL__4 = 4,
	ADC_CHANNEL__5 = 5,
	ADC_CHANNEL__6 = 6,
	ADC_CHANNEL__7 = 7,
	ADC_CHANNEL__8 = 8,
	ADC_CHANNEL__9 = 9,
	ADC_CHANNEL__10 = 10,
	ADC_CHANNEL__11 = 11,
	ADC_CHANNEL__12 = 12,
	ADC_CHANNEL__13 = 13,
	ADC_CHANNEL__14 = 14,
	ADC_CHANNEL__15 = 15,
	ADC_CHANNEL__16 = 16,
	ADC_CHANNEL__17 = 17,
	ADC_CHANNEL__18 = 18
}ADC_Channel;

void General_GPIO_Init(void);
void CV_Dual_DAC_Init(float volt1, float volt2, int16_t psc, int32_t arr);
void CV_Single_ADC_Init(ADC_Channel channel, Sample_Time sample_t, int16_t psc, int32_t arr, int32_t *adc_dma);
void UART_Transmit_Init(void);
void IS_Dual_ADC_Init(ADC_Channel, ADC_Channel, Sample_Time, int16_t, int32_t, uint32_t*);
void IS_Dual_DAC_Init(int16_t , int32_t, uint16_t*, uint16_t*);
void DPV_Timer3_DAC_Init(float volt1, float volt2, int16_t psc, int32_t arr);
void DMA_MemToMem_Xfer(void);
#endif /* APPLICATION_USER_PERIPHERAL_INITIAL_H_ */

