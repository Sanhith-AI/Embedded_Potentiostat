/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
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

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "User_Function.h"
#include "Peripheral_Initial.h"
#include "string.h"
#include "stdio.h"
#include<math.h>
#include<stdlib.h>
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */
uint8_t receivedData[40];
uint8_t unit_temp;

uint* temp0;
uint* temp1;
uint* temp2;
uint* temp3;
uint* temp4;
uint* temp5;
uint* temp6;
uint* temp7;
uint* temp8;
uint* temp9;

int8_t *UARTTemp;
char transmit_buffer[40];
uint8_t buff_length;

int method = 0;
char methodName [20];
 char unit[4];

//Variables for Impedance spectroscopy
char frequency_type[6];
char min_frequency_unit[4];
char max_frequency_unit[4];
char error[50];
int rand_count=1;
uint16_t Frequency_List[IS_MaxNoOfSineFreq];
float Frequency_List1[IS_MaxNoOfSineFreq];
uint8_t IS_default_switch_value=0x04;

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
SPI_HandleTypeDef hspi3;

UART_HandleTypeDef huart4;
UART_HandleTypeDef huart5;

/* USER CODE BEGIN PV */

//char sendingData[30];
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_UART4_Init(void);
static void MX_UART5_Init(void);
static void MX_SPI3_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
void Nucleo_LED(void);
void Nucleo_LED()
{
	RCC->AHBENR |= 0x040000;
	GPIOB->MODER |=0x4000;
	LED_On_GPIO_SetLow(GPIOB,GPIO_PIN_7);
//	LED_Off_GPIO_SetHigh(GPIOB,GPIO_PIN_7);
}


/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_UART4_Init();
  MX_UART5_Init();
  MX_SPI3_Init();
  /* USER CODE BEGIN 2 */
  General_GPIO_Init();

  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  Nucleo_LED();


  while(1)
  {

	  	 HAL_UART_Receive(&huart5, receivedData, 40,5000);

	  	  	  	temp9=(uint*)(receivedData[36]|(receivedData[37]<<8)|(receivedData[38]<<16)|(receivedData[39]<<24));
	  	    	temp8=(uint*)(receivedData[32]|(receivedData[33]<<8)|(receivedData[34]<<16)|(receivedData[35]<<24));
	  	    	temp7=(uint*)(receivedData[28]|(receivedData[29]<<8)|(receivedData[30]<<16)|(receivedData[31]<<24));
	  	    	temp6=(uint*)(receivedData[24]|(receivedData[25]<<8)|(receivedData[26]<<16)|(receivedData[27]<<24));
	  	    	temp5=(uint*)(receivedData[20]|(receivedData[21]<<8)|(receivedData[22]<<16)|(receivedData[23]<<24));
	  	    	temp4=(uint*)(receivedData[16]|(receivedData[17]<<8)|(receivedData[18]<<16)|(receivedData[19]<<24));
	  	    	temp3=(uint*)(receivedData[12]|(receivedData[13]<<8)|(receivedData[14]<<16)|(receivedData[15]<<24));
	  	    	temp2=(uint*)(receivedData[8]|(receivedData[9]<<8)|(receivedData[10]<<16)|(receivedData[11]<<24));
	  	    	temp1=(uint*)(receivedData[4]|(receivedData[5]<<8)|(receivedData[6]<<16)|(receivedData[7]<<24));
	  	    	temp0=(uint*)(receivedData[0]|(receivedData[1]<<8)|(receivedData[2]<<16)|(receivedData[3]<<24));

	  	    	int method_temp = *(int*)&temp0;

	  	    	if(method_temp==1)
	  	    	{
	  	    		method= *(int*)&temp0;
	  	    		receivedData[0] = 0;
	  	    		receivedData[1] = 0;
	  	    		receivedData[2] = 0;
	  	    		receivedData[3] = 0;
	  	    		sprintf(methodName,"Cyclic");
	  	    		CVT.estart=*(float*)&temp1;
	  	    		CVT.estop=*(float*)&temp2;
	  	    		CVT.current=*(int*)&temp3;
	  	    		int unit_temp=*(int*)&temp4;
	  	    		if(unit_temp==1)
	  	    		{
	  	    			sprintf(unit,"pA");
	  	    		}
	  	    		else if(unit_temp ==2)
	  	    		{
	  	    			sprintf(unit,"nA");
	  	    		}
	  	    		else if(unit_temp==3)
	  	    		{
	  	    			sprintf(unit,"µA");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(unit,"mA");
	  	    		}
	  	    		CVT.estep=*(float*)&temp5;

	  	    		CVT.scanrate=*(float*)&temp6;
	  	    		CVT.noofscans=*(int*)&temp7;

	  	    	}
	  	    	else if(method_temp==2)
	  	    	{
	  	    		method= *(int*)&temp0;
	  	    		receivedData[0] = 0;
	  	    		receivedData[1] = 0;
	  	    		receivedData[2] = 0;
	  	    		receivedData[3] = 0;
	  	    		sprintf(methodName,"Square wave");
	  	    		CVT.estart=*(float*)&temp1;
	  	    		CVT.estop=*(float*)&temp2;
	  	    		CVT.current=*(int*)&temp3;
	  	    		int unit_temp=*(int*)&temp4;
	  	    		if(unit_temp==1)
	  	    		{
	  	    			sprintf(unit,"pA");
	  	    		}
	  	    		else if(unit_temp ==2)
	  	    		{
	  	    			sprintf(unit,"nA");
	  	    		}
	  	    		else if(unit_temp==3)
	  	    		{
	  	    			sprintf(unit,"µA");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(unit,"mA");
	  	    		}

	  	    		CVT.estep=*(float*)&temp5;
	  	    		SWVT.amplitude=*(float*)&temp6;
	  	    		SWVT.frequency=*(float*)&temp7;

	  	    	}
	  	    	else if(method_temp==4)
	  	    	{
	  	    		method= *(int*)&temp0;
	  	    		receivedData[0] = 0;
	  	    		receivedData[1] = 0;
	  	    		receivedData[2] = 0;
	  	    		receivedData[3] = 0;
	  	    		sprintf(methodName,"Differential pulse");
	  	    		CVT.estart=*(float*)&temp1;
	  	    		CVT.estop=*(float*)&temp2;
	  	    		CVT.current=*(int*)&temp3;
	  	    		int unit_temp=*(int*)&temp4;
	  	    		if(unit_temp==1)
	  	    		{
	  	    			sprintf(unit,"pA");
	  	    		}
	  	    		else if(unit_temp ==2)
	  	    		{
	  	    			sprintf(unit,"nA");
	  	    		}
	  	    		else if(unit_temp==3)
	  	    		{
	  	    			sprintf(unit,"µA");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(unit,"mA");
	  	    		}

	  	    		CVT.estep=*(float*)&temp5;
	  	    		DPVT.amplitude=*(float*)&temp6;
	  	    		CVT.scanrate=*(float*)&temp7;
	  	    		DPVT.Tpulse=*(float*)&temp8;

	  	    	}
	  	    	else if(method_temp==3)
	  	    	{
	  	    		method= *(int*)&temp0;
	  	    		receivedData[0] = 0;
	  	    		receivedData[1] = 0;
	  	    		receivedData[2] = 0;
	  	    		receivedData[3] = 0;
	  	    		sprintf(methodName,"Impedance");
	  	    		IST.edc=*(float*)&temp1;
	  	    		IST.eac=*(float*)&temp2;
	  	    		IST.current=*(int*)&temp3;
	  	    		int unit_temp=*(int*)&temp4;
	  	    		if(unit_temp==1)
	  	    		{
	  	    			sprintf(unit,"pA");
	  	    		}
	  	    		else if(unit_temp ==2)
	  	    		{
	  	    			sprintf(unit,"nA");
	  	    		}
	  	    		else if(unit_temp==3)
	  	    		{
	  	    			sprintf(unit,"µA");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(unit,"mA");
	  	    		}
	  	    		int freqtypeno=*(int*)&temp5;
	  	    		if(freqtypeno==1)
	  	    		{
	  	    			sprintf(frequency_type,"Fixed");
	  	    		}
	  	    		else if (freqtypeno==2)
	  	    		{
	  	    			sprintf(frequency_type,"Scan");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(frequency_type,"NA");
	  	    		}
	  	    		IST.frequency=*(float*)&temp6;
	  	    		IST.min_frequency=*(float*)&temp7;
	  	    		int temp_freqtype;
	  	    		temp_freqtype = *(int*)&temp8;

	  	    		if(temp_freqtype==1)
	  	    		{
	  	    			sprintf(min_frequency_unit,"Hz");
	  	    		}
	  	    		else if (temp_freqtype==2)
	  	    		{
	  	    			sprintf(min_frequency_unit,"kHz");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(min_frequency_unit,"NA");
	  	    		}
	  	    		IST.max_frequency=*(float*)&temp9;
	  	    		if(IST.max_frequency)
	  	    		{
	  	    			sprintf(max_frequency_unit,"kHz");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(max_frequency_unit,"NA");
	  	    		}


	  	    	}
	  	    	else
	  	    	{

	  	    		if(method == 0)
	  	    		{
	  	    			sprintf(error,"Waiting for receivedData");
	  	    		}
	  	    		else
	  	    		{
	  	    			sprintf(error,"Error while receiving receivedData");
	  	    		}
	  	    	}
if(rand_count==1)
{
	if((method==1) | (method==2) | (method==4))
	{


		  CV_Flag_Var_Init();

		  uint8_t switch_volta=0x14;

		  HAL_GPIO_WritePin(GPIOD, GPIO_PIN_10, GPIO_PIN_RESET);

		  HAL_SPI_Transmit(&hspi3,&switch_volta,1,100);

		  HAL_GPIO_WritePin(GPIOD, GPIO_PIN_10, GPIO_PIN_SET);

	}

	else if(method==3)
	{

		  HAL_GPIO_WritePin(GPIOD, GPIO_PIN_10, GPIO_PIN_RESET);

		  HAL_SPI_Transmit(&hspi3,&IS_default_switch_value,1,100);

		  HAL_GPIO_WritePin(GPIOD, GPIO_PIN_10, GPIO_PIN_SET);





		if(IST.frequency!=0)
		{
			Frequency_List[0] = (uint16_t)IST.frequency;
			Frequency_List[1] =0;
			Frequency_List1[0] = IST.frequency;
			Frequency_List1[1] =0;
		}

		else if(IST.min_frequency==1)
		{
			Frequency_List[0]=(uint16_t)IST.min_frequency;
			Frequency_List[1]=2;
			Frequency_List[2]=5;
			Frequency_List[3]=10;
			Frequency_List[4]=25;
			Frequency_List[5]=50;
			Frequency_List[6]=75;
			Frequency_List[7]=100;
			Frequency_List[8]=150;
			Frequency_List[9]=200;
			Frequency_List[10]=250;
			Frequency_List[11]=300;Frequency_List[12]=400;Frequency_List[13]=500;Frequency_List[14]=600;Frequency_List[15]=750;Frequency_List[16]=1000;Frequency_List[17]=1500;Frequency_List[18]=2000;
			Frequency_List[19]=2500;Frequency_List[20]=3000;Frequency_List[21]=5000;Frequency_List[22]=6000;Frequency_List[23]=7500;Frequency_List[24]=9000;Frequency_List[25]=IST.max_frequency*1000;

			Frequency_List1[0]=IST.min_frequency;
			Frequency_List1[1]=2;
			Frequency_List1[2]=5;
			Frequency_List1[3]=10;
			Frequency_List1[4]=25;
			Frequency_List1[5]=50;
			Frequency_List1[6]=75;
			Frequency_List1[7]=100;
			Frequency_List1[8]=150;
			Frequency_List1[9]=200;
			Frequency_List1[10]=250;
			Frequency_List1[11]=300;Frequency_List1[12]=400;Frequency_List1[13]=500;Frequency_List1[14]=600;Frequency_List1[15]=750;Frequency_List1[16]=1000;Frequency_List1[17]=1500;Frequency_List1[18]=2000;
			Frequency_List1[19]=2500;Frequency_List1[20]=3000;Frequency_List1[21]=5000;Frequency_List1[22]=6000;Frequency_List1[23]=7500;Frequency_List1[24]=9000;Frequency_List1[25]=IST.max_frequency*1000;
		}

		else if(IST.min_frequency==10)
		{
			Frequency_List[0]=(uint16_t)IST.min_frequency;
			Frequency_List[1]=25;
			Frequency_List[2]=50;
			Frequency_List[3]=75;
			Frequency_List[4]=100;
			Frequency_List[5]=150;
			Frequency_List[6]=200;
			Frequency_List[7]=250;
			Frequency_List[8]=300;Frequency_List[9]=400;Frequency_List[10]=500;Frequency_List[11]=600;Frequency_List[12]=750;Frequency_List[13]=1000;Frequency_List[14]=1500;Frequency_List[15]=2000;
			Frequency_List[16]=2500;Frequency_List[17]=3000;Frequency_List[18]=5000;Frequency_List[19]=6000;Frequency_List[20]=7500;Frequency_List[21]=9000;Frequency_List[22]=(uint16_t)IST.max_frequency*1000;

			Frequency_List1[0]=IST.min_frequency;
			Frequency_List1[1]=25;
			Frequency_List1[2]=50;
			Frequency_List1[3]=75;
			Frequency_List1[4]=100;
			Frequency_List1[5]=150;
			Frequency_List1[6]=200;
			Frequency_List1[7]=250;
			Frequency_List1[8]=300;Frequency_List1[9]=400;Frequency_List1[10]=500;Frequency_List1[11]=600;Frequency_List1[12]=750;Frequency_List1[13]=1000;Frequency_List1[14]=1500;Frequency_List1[15]=2000;
			Frequency_List1[16]=2500;Frequency_List1[17]=3000;Frequency_List1[18]=5000;Frequency_List1[19]=6000;Frequency_List1[20]=7500;Frequency_List1[21]=9000;Frequency_List1[22]=IST.max_frequency*1000;
		}

		else if(IST.min_frequency==100)
				{
					Frequency_List[0]=(uint16_t)IST.min_frequency;
					Frequency_List[1]=150;
					Frequency_List[2]=200;
					Frequency_List[3]=250;
					Frequency_List[4]=300;Frequency_List[5]=400;Frequency_List[6]=500;Frequency_List[7]=600;Frequency_List[8]=750;Frequency_List[9]=1000;Frequency_List[10]=1500;Frequency_List[11]=2000;
					Frequency_List[12]=2500;Frequency_List[13]=3000;Frequency_List[14]=5000;Frequency_List[15]=6000;Frequency_List[16]=7500;Frequency_List[17]=9000;Frequency_List[18]=(uint16_t)IST.max_frequency*1000;

					Frequency_List1[0]=IST.min_frequency;
					Frequency_List1[1]=150;
					Frequency_List1[2]=200;
					Frequency_List1[3]=250;
					Frequency_List1[4]=300;Frequency_List1[5]=400;Frequency_List1[6]=500;Frequency_List1[7]=600;Frequency_List1[8]=750;Frequency_List1[9]=1000;Frequency_List1[10]=1500;Frequency_List1[11]=2000;
					Frequency_List1[12]=2500;Frequency_List1[13]=3000;Frequency_List1[14]=5000;Frequency_List1[15]=6000;Frequency_List1[16]=7500;Frequency_List1[17]=9000;Frequency_List1[18]=IST.max_frequency*1000;
				}
		else if(IST.min_frequency==1000)
				{
					Frequency_List[0]=(uint16_t)IST.min_frequency;Frequency_List[1]=1500;Frequency_List[2]=2000;
					Frequency_List[3]=2500;Frequency_List[4]=3000;Frequency_List[5]=5000;Frequency_List[6]=6000;Frequency_List[7]=7500;Frequency_List[8]=9000;Frequency_List[9]=(uint16_t)IST.max_frequency*1000;

					Frequency_List1[0]=IST.min_frequency;Frequency_List1[1]=1500;Frequency_List1[2]=2000;
					Frequency_List1[3]=2500;Frequency_List1[4]=3000;Frequency_List1[5]=5000;Frequency_List1[6]=6000;Frequency_List1[7]=7500;Frequency_List1[8]=9000;Frequency_List1[9]=IST.max_frequency*1000;
				}

		IS_Start();



	}
}
if(method==1)
{
	CV_Start();
	rand_count=2;

}
else if(method==2)
{
	SWV_Start();
	rand_count=2;

}
else if(method==4)
{
	DPV_Start();
	rand_count=2;

}
else if(method==3)
{
	IS_Complete();
	rand_count=2;
}
else
{
	rand_count=1;
}

    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};
  RCC_PeriphCLKInitTypeDef PeriphClkInit = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSI;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.HSICalibrationValue = RCC_HSICALIBRATION_DEFAULT;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSI;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL9;
  RCC_OscInitStruct.PLL.PREDIV = RCC_PREDIV_DIV1;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    Error_Handler();
  }
  PeriphClkInit.PeriphClockSelection = RCC_PERIPHCLK_UART4|RCC_PERIPHCLK_UART5;
  PeriphClkInit.Uart4ClockSelection = RCC_UART4CLKSOURCE_PCLK1;
  PeriphClkInit.Uart5ClockSelection = RCC_UART5CLKSOURCE_PCLK1;
  if (HAL_RCCEx_PeriphCLKConfig(&PeriphClkInit) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief SPI3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_SPI3_Init(void)
{

  /* USER CODE BEGIN SPI3_Init 0 */

  /* USER CODE END SPI3_Init 0 */

  /* USER CODE BEGIN SPI3_Init 1 */

  /* USER CODE END SPI3_Init 1 */
  /* SPI3 parameter configuration*/
  hspi3.Instance = SPI3;
  hspi3.Init.Mode = SPI_MODE_MASTER;
  hspi3.Init.Direction = SPI_DIRECTION_2LINES;
  hspi3.Init.DataSize = SPI_DATASIZE_8BIT;
  hspi3.Init.CLKPolarity = SPI_POLARITY_LOW;
  hspi3.Init.CLKPhase = SPI_PHASE_2EDGE;
  hspi3.Init.NSS = SPI_NSS_SOFT;
  hspi3.Init.BaudRatePrescaler = SPI_BAUDRATEPRESCALER_128;
  hspi3.Init.FirstBit = SPI_FIRSTBIT_MSB;
  hspi3.Init.TIMode = SPI_TIMODE_DISABLE;
  hspi3.Init.CRCCalculation = SPI_CRCCALCULATION_DISABLE;
  hspi3.Init.CRCPolynomial = 7;
  hspi3.Init.CRCLength = SPI_CRC_LENGTH_DATASIZE;
  hspi3.Init.NSSPMode = SPI_NSS_PULSE_DISABLE;
  if (HAL_SPI_Init(&hspi3) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN SPI3_Init 2 */

  /* USER CODE END SPI3_Init 2 */

}

/**
  * @brief UART4 Initialization Function
  * @param None
  * @retval None
  */
static void MX_UART4_Init(void)
{

  /* USER CODE BEGIN UART4_Init 0 */

  /* USER CODE END UART4_Init 0 */

  /* USER CODE BEGIN UART4_Init 1 */

  /* USER CODE END UART4_Init 1 */
  huart4.Instance = UART4;
  huart4.Init.BaudRate = 115200;
  huart4.Init.WordLength = UART_WORDLENGTH_8B;
  huart4.Init.StopBits = UART_STOPBITS_1;
  huart4.Init.Parity = UART_PARITY_NONE;
  huart4.Init.Mode = UART_MODE_TX_RX;
  huart4.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart4.Init.OverSampling = UART_OVERSAMPLING_16;
  huart4.Init.OneBitSampling = UART_ONE_BIT_SAMPLE_DISABLE;
  huart4.AdvancedInit.AdvFeatureInit = UART_ADVFEATURE_NO_INIT;
  if (HAL_UART_Init(&huart4) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN UART4_Init 2 */

  /* USER CODE END UART4_Init 2 */

}

/**
  * @brief UART5 Initialization Function
  * @param None
  * @retval None
  */
static void MX_UART5_Init(void)
{

  /* USER CODE BEGIN UART5_Init 0 */

  /* USER CODE END UART5_Init 0 */

  /* USER CODE BEGIN UART5_Init 1 */

  /* USER CODE END UART5_Init 1 */
  huart5.Instance = UART5;
  huart5.Init.BaudRate = 115200;
  huart5.Init.WordLength = UART_WORDLENGTH_8B;
  huart5.Init.StopBits = UART_STOPBITS_1;
  huart5.Init.Parity = UART_PARITY_NONE;
  huart5.Init.Mode = UART_MODE_TX_RX;
  huart5.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart5.Init.OverSampling = UART_OVERSAMPLING_16;
  huart5.Init.OneBitSampling = UART_ONE_BIT_SAMPLE_DISABLE;
  huart5.AdvancedInit.AdvFeatureInit = UART_ADVFEATURE_NO_INIT;
  if (HAL_UART_Init(&huart5) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN UART5_Init 2 */

  /* USER CODE END UART5_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOF_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOD, GPIO_PIN_8|GPIO_PIN_9|GPIO_PIN_10|GPIO_PIN_13, GPIO_PIN_RESET);

  /*Configure GPIO pins : PD8 PD9 PD10 PD13 */
  GPIO_InitStruct.Pin = GPIO_PIN_8|GPIO_PIN_9|GPIO_PIN_10|GPIO_PIN_13;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */

  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     tex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

