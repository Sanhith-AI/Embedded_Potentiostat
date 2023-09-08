################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (9-2020-q2-update)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../STM32CubeIDE/Application/source/PeripheralInit.c \
../STM32CubeIDE/Application/source/UserFunctions.c 

OBJS += \
./STM32CubeIDE/Application/source/PeripheralInit.o \
./STM32CubeIDE/Application/source/UserFunctions.o 

C_DEPS += \
./STM32CubeIDE/Application/source/PeripheralInit.d \
./STM32CubeIDE/Application/source/UserFunctions.d 


# Each subdirectory must supply rules for building sources it contributes
STM32CubeIDE/Application/source/%.o: ../STM32CubeIDE/Application/source/%.c STM32CubeIDE/Application/source/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m4 -std=gnu11 -g3 -DDEBUG -DARM_MATH_CM4 -DUSE_HAL_DRIVER -DSTM32F303xE -c -I../Inc -I"C:/Users/User/Desktop/thesis images/Nitramon_V1.0/Nitramon_V1.0/STM32CubeIDE/Application/header" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/Core/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/DSP/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/NN/Include" -I../Drivers/STM32F3xx_HAL_Driver/Inc -I../Drivers/STM32F3xx_HAL_Driver/Inc/Legacy -I../Drivers/CMSIS/Device/ST/STM32F3xx/Include -I../Drivers/CMSIS/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" --specs=nano.specs -mfpu=fpv4-sp-d16 -mfloat-abi=hard -mthumb -o "$@"

clean: clean-STM32CubeIDE-2f-Application-2f-source

clean-STM32CubeIDE-2f-Application-2f-source:
	-$(RM) ./STM32CubeIDE/Application/source/PeripheralInit.d ./STM32CubeIDE/Application/source/PeripheralInit.o ./STM32CubeIDE/Application/source/UserFunctions.d ./STM32CubeIDE/Application/source/UserFunctions.o

.PHONY: clean-STM32CubeIDE-2f-Application-2f-source

