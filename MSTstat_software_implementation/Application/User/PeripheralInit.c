#include "stm32f303xe.h"
#include "Peripheral_Initial.h"
#include "main.h"

void General_GPIO_Init()
{
	RCC->AHBENR |= 0x0200000;
	GPIOE->MODER |= 0x15500000;  // LED- PE10-14, output mode
	GPIOE->OSPEEDR |= 0x3FF00000; // high speed PE10-14
}

void CV_Dual_DAC_Init(float volt1, float volt2, int16_t psc, int32_t arr)
{
	/*------------------------------- Configure timer 4 -------------------------------*/
	RCC->APB1ENR |= (1 << 2);							// Enable TIM4 clock
	TIM4->CR2 |= 0x20;									// Update event is selected as trigger output TRGO event
	TIM4->PSC = psc;									// Prescaler value
	TIM4->ARR = arr;									// Auto reload register
	TIM4->CR1 |= 0x0004;								// clk_division=0, auto-reload preload disable, upcounter, one-pulse mode disable, counter overflow interrupt, UEV disable
	TIM4->DIER = 0x0001;								// Update interrupt enable
								// Enable Timer2 NVIC interrupt
	/*---------------------------- DAC1 CH1 configuration -----------------------------*/
	RCC->APB1ENR |= (1 << 29);							// Enable DAC1 interface clock
	RCC->AHBENR |= (1 << 17); 							// Enable GPIOA clock
	GPIOA->MODER |= 0b11 << (4 * 2);					// Set PA4 as analog
	DAC1->CR |= 0x2D; //0x3B;							// DAC1 CH1 wave generation disable, CH1 buffered, CH1 enable
	DAC1->DHR12RD = (uint16_t)(volt1);		// Load desired value in 12 bit right aligned data holding register

	GPIOA->MODER |= 0b11 << (5 * 2);					// Set PA5 as analog
	DAC1->CR |= (0x2D << 16); //(0x3B << 16);			// DAC1 CH2 wave generation disable, CH2 buffered, CH2 enable
	DAC1->DHR12RD |= (uint16_t)(volt2) << 16;	// Load desired value in 12 bit right aligned data holding register
	TIM4->CR1 |= 0x01;									// counter enable
}

void CV_Single_ADC_Init(ADC_Channel channel, Sample_Time sample_t, int16_t psc, int32_t arr, int32_t *adc_dma)
{
	/*------------------------------- Configure timer 2 -------------------------------*/
	RCC->APB1ENR |= 0x01;//0x00000001;				// Enable TIM2 clock
	TIM2->CR2 |= 0x20;								// Update event is selected as trigger output ( For ADC external trigger )
	TIM2->PSC = psc;								// Prescaler value
	TIM2->ARR = arr;								// Auto reload register
	TIM2->CR1 |= 0x0004;							// clk_division=0, auto-reload preload disable, upcounter, one-pulse mode disable, counter overflow interrupt, UEV disable, counter disable
	/*------------------------------- Configure ADC1 ----------------------------------*/
	RCC->AHBENR |= 0x10000000; 						// Enable ADC12 clock
	RCC->CFGR2 |= 0x100;							// Set ADC12 prescaler to PLL clock divided by 1
	RCC->AHBENR |= 0x20000;							// Enable GPIOA clock
	GPIOA->MODER |= 0b11 << (channel-1)*2;			// Enable analog mode on GPIOA pin
	GPIOA->OSPEEDR |= 0b11 << (channel-1)*2;		// GPIOA high speed

	ADC1->CR &= ~0x20000000;
	HAL_Delay(2);
	ADC1->CR |= 0x10000000;							// Launch ADC calibration in single ended mode
	HAL_Delay(10);									// Wait for ADC voltage regulator to get enabled
	ADC1->CR |= 0x80000000;							// Start ADC calibration
	while(ADC1->CR & 0x80000000);					// wait for ADC calibration to be finished*/
	ADC1->CFGR |= 0x1000;							// Overrun data overwritten, right data alignment, 12 bit, DMA disabled
	ADC1->CR |= 0x01;								// Enable ADC1
	ADC1->SQR1 = (channel << 6);					// Set number of conversions to 1 and channel number
	if(channel <= 9)
		ADC1->SMPR1 |= (sample_t << (3*channel));	// Set sampling time
	else
		ADC1->SMPR2 |= (sample_t << (channel-10)*3);
	ADC1->CR &= ~(1 << 2);							// stop adc conversion
	ADC1->CFGR |= 0xEC0;							// Enable external trigger on rising & falling Edge of TIM2_TRGO event
    ADC1->SQR1 |= 0x40;
    //ADC1->CALFACT = 80;
	ADC1->IER |= (1 << 2);							// End of regular conversion interrupt enable
	ADC1->CR |= (1 << 2);							// start adc conversion
}
void UART_Transmit_Init()
{
	// UART5 PC12 is TX
/*	RCC->APB1ENR |= 0x100000; // UART5 Clock
	RCC->AHBENR |= 0x80000;  // GPIOC Clock
	GPIOC->MODER |= 0x2000000;
	GPIOC->OSPEEDR |= 0x3000000;
	GPIOC->AFR[1] |= 0x50000;
	UART5->BRR = 3750;
	UART5->CR1 |= 0x01; */

	// UART4 PC10 is TX
	RCC->APB1ENR |= 0x80000; // UART4 Clock
	RCC->AHBENR |= 0x80000;  // GPIOC Clock
	GPIOC->MODER |= 0x200000;
	GPIOC->OSPEEDR |= 0x300000;
	GPIOC->AFR[1] |= 0x500;
	UART4->BRR = 3750;
	UART4->CR1 |= 0x01;
}

void IS_Dual_ADC_Init(ADC_Channel channel1, ADC_Channel channel2, Sample_Time sample_t, int16_t psc, int32_t arr, uint32_t *adc_dma)
{
	/*------------------------------- Configure ADC1 ----------------------------------*/


	//RCC->CFGR2 |= 0x100;							// Set ADC12 prescaler to PLL clock divided by 1

	RCC->AHBENR |= 0x20000;							// Enable GPIOA clock
	RCC->CFGR2 |= 0x100;							// Set ADC12 prescaler to PLL clock divided by 1
	/*GPIOA->MODER |= 0b11 << (channel1-1)*2;			// Enable analog mode on GPIOA channel1 pin
	GPIOA->OSPEEDR |= 0b11 << (channel1-1)*2;		// GPIOA channel1 high speed
	GPIOA->MODER |= 0b11 << (channel2-1+4)*2;			// Enable analog mode on GPIOA channel2 pin
	GPIOA->OSPEEDR |= 0b11 << (channel2-1+4)*2;		// GPIOA channel2 high speed
*/

	GPIOA->MODER |= 0x30;  //PA2
    GPIOA->OSPEEDR |= 0x30;
    //GPIOA->MODER |= 0x03;  //PA0
    //GPIOA->OSPEEDR |= 0x03;
    GPIOA->MODER |= 0x3000;  //PA6
    GPIOA->OSPEEDR |= 0x3000;
   //GPIOA->MODER |= 0xC000; // PA7
    //GPIOA->OSPEEDR |= 0xC000;
	RCC->AHBENR |= 0x10000000; 						// Enable ADC12 clock
	ADC1->CR &= ~0x20000000;
	HAL_Delay(2);
	ADC1->CR |= 0x10000000;							// Launch ADC calibration in single ended mode
	HAL_Delay(10);									// Wait for ADC voltage regulator to get enabled
	ADC1->CR |= 0x80000000;			//				// Start ADC calibration
	while(ADC1->CR & 0x80000000);		//			// wait for ADC calibration to be finished
	ADC1->CR |= 0x01;								// Enable ADC1
	while((ADC1->ISR & 0x01) == 0);//
	//ADC1->SQR1 = (channel1 << 6);					// Set number of conversions to 1 and channel number
	ADC1->CR &= ~(1 << 2);		//					// stop adc conversion
	ADC1->SQR1 = (channel1 << 6);
	ADC1->CFGR |= 	0X1EC0;		//0x16C0;				// Overrun data overwritten, Enable external trigger on rising Edge of TIM2_TRGO event

	ADC2->CR &= ~0x20000000;
	HAL_Delay(2);
	ADC2->CR |= 0x10000000;							// Launch ADC calibration in single ended mode
	HAL_Delay(10);									// Wait for ADC voltage regulator to get enabled
	ADC2->CR |= 0x80000000;	//						// Start ADC calibration
	while(ADC2->CR & 0x80000000);	//				// wait for ADC calibration to be finished
	ADC2->CR |= 0x01;								// Enable ADC2
	while((ADC2->ISR & 0x01) == 0); //
	ADC2->SQR1 = (channel2 << 6);					// Set number of conversions to 1 and channel number
////////// Important //////////////////
	ADC12_COMMON->CCR |= 0x30406; //0x3406; //0x10006;			// Regular simultaneous mode

	//ADC2->CR |= 0x01;								// Enable ADC2
	/*------------------------------- Configure timer 2 -------------------------------*/
	RCC->APB1ENR |= 0x01;//0x00000001;				// Enable TIM2 clock
		TIM2->CR2 |= 0x20;								// Update event is selected as trigger output ( For ADC external trigger )
		TIM2->PSC = psc;								// Prescaler value
		TIM2->ARR = arr;								// Auto reload register
		TIM2->CR1 |= 0x0004;							// clk_division=0, auto-reload preload disable, upcounter, one-pulse mode disable, counter overflow interrupt, UEV disable, counter disable

	ADC1->IER |= 0x04;							// End of regular conversion interrupt enable
	//ADC1->CR |= 0x01;								// Enable ADC1
	ADC1->CR |=   0x04;   //(1 << 2);							// start adc1 conversion
	ADC2->CR |= (1 << 2);							// start adc2 conversion
	NVIC_EnableIRQ(ADC1_IRQn);

}


/*-------------------------------------------------------------------------------------*
   * 				Dual DAC Configuration
   */
void IS_Dual_DAC_Init(int16_t psc, int32_t arr, uint16_t *ch1_array, uint16_t *ch2_array)
{
	/*------------------------------- Configure timer 4 -------------------------------*/
	RCC->APB1ENR |= (1 << 2);							// Enable TIM4 clock
	TIM4->CR2 |= 0x20;									// Update event is selected as trigger output TRGO event
	TIM4->PSC = psc;									// Prescaler value
	TIM4->ARR = arr;									// Auto reload register
	TIM4->CR1 |= 0x0004;								// clk_division=0, auto-reload preload disable, upcounter, one-pulse mode disable, counter overflow interrupt, UEV disable

	/*---------------------------- DAC1 CH1 configuration -----------------------------*/
	RCC->APB1ENR |= (1 << 29);							// Enable DAC1 interface clock
	RCC->AHBENR |= (1 << 17); 							// Enable GPIOA clock
	GPIOA->MODER |= 0b11 << (4 * 2);					// Set PA4 as analog
	DAC1->CR |= 0x2D; //0x3B;							// DAC1 CH1 wave generation disable, CH1 buffered, CH1 enable

	//DAC1->DHR12RD = (uint16_t)((ch1_array[0]/3.3)*4095);		// Load desired value in 12 bit right aligned data holding register
	/*---------------------------------- Configure DMA --------------------------------*/
	DAC1->CR |= 0x1000;									// Enable DMA
	SYSCFG->CFGR1 |= (1 << 13);							// DAC1 CH1 DMA requests mapped on DMA1 channel 3
	RCC->AHBENR |= 0x01;								// Enable DMA1 clock
	DMA1_Channel3->CPAR = (uint32_t)(&DAC1->DHR12R1);
	DMA1_Channel3->CMAR = (uint32_t)ch1_array;
	DMA1_Channel3->CNDTR = 32;
	DMA1_Channel3->CCR |= 0x25B0;
	DMA1_Channel3->CCR |= 0x01;

	/*---------------------------- DAC1 CH2 configuration -----------------------------*/
	GPIOA->MODER |= 0b11 << (5 * 2);					// Set PA5 as analog
	DAC1->CR |= (0x2D << 16); //(0x3B << 16);			// DAC1 CH2 wave generation disable, CH2 buffered, CH2 enable
//	DAC1->DHR12RD |= (uint16_t)((volt2/3.3)*4095) << 16;	// Load desired value in 12 bit right aligned data holding register
//	DAC1->DHR12R2 = ch2_array[0];

	/*---------------------------------- Configure DMA --------------------------------*/
	DAC1->CR |= 0x10000000;									// Enable DMA
	SYSCFG->CFGR1 |= (1 << 14);							// DAC_CH2 DMA requests mapped on DMA1 channel 4
	DMA1_Channel4->CPAR = (uint32_t)(&DAC1->DHR12R2);
	DMA1_Channel4->CMAR = (uint32_t)ch2_array;
	DMA1_Channel4->CNDTR = 101;
	DMA1_Channel4->CCR |= 0x25B0;
	DMA1_Channel4->CCR |= 0x01;
}

void DPV_Timer3_DAC_Init(float volt1, float volt2, int16_t psc, int32_t arr)
{
	/*------------------------------- Configure timer 4 -------------------------------*/
			RCC->APB1ENR |= (1 << 2);							// Enable TIM4 clock
			TIM4->CR2 |= 0x20;									// Update event is selected as trigger output TRGO event
			TIM4->PSC = psc;									// Prescaler value
			TIM4->ARR = arr;									// Auto reload register
			TIM4->CR1 |= 0x0004;  								// clk_division=0, auto-reload preload disable, upcounter, one-pulse mode disable, counter overflow interrupt, UEV disable
			TIM4->DIER = 0x0001;								// Update interrupt enable

			/*---------------------------- DAC1 CH1 configuration -----------------------------*/
			RCC->APB1ENR |= (1 << 29);							// Enable DAC1 interface clock
			RCC->AHBENR |= (1 << 17); 							// Enable GPIOA clock
			GPIOA->MODER |= 0b11 << (4 * 2);					// Set PA4 as analog
			DAC1->CR |= 0x2D; //0x3B;							// DAC1 CH1 wave generation disable, CH1 buffered, CH1 enable
			DAC1->DHR12RD = (uint16_t)(volt1);		// Load desired value in 12 bit right aligned data holding register

			GPIOA->MODER |= 0b11 << (5 * 2);					// Set PA5 as analog
			DAC1->CR |= (0x2D << 16); //(0x3B << 16);			// DAC1 CH2 wave generation disable, CH2 buffered, CH2 enable
			DAC1->DHR12RD |= (uint16_t)(volt2) << 16;	// Load desired value in 12 bit right aligned data holding register
			TIM4->CR1 |= 0x01;


}

void DMA_MemToMem_Xfer()
{
 RCC->AHBENR |= 0x02;							// Enable DMA2 clock
 DMA2_Channel1->CPAR = (uint32_t)(&ADC1->DR);	// Peripheral address
 //DMA2_Channel1->CMAR = (uint32_t)adc_dma;		// Destination memory address
 DMA2_Channel1->CNDTR = 1;
 DMA2_Channel1->CCR |= 0x075B0;
 DMA2_Channel1->CCR |= 0x01;
}
