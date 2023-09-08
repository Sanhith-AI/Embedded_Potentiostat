################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (9-2020-q2-update)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Application/User/PeripheralInit.c \
../Application/User/UserFunctions.c 

OBJS += \
./Application/User/PeripheralInit.o \
./Application/User/UserFunctions.o 

C_DEPS += \
./Application/User/PeripheralInit.d \
./Application/User/UserFunctions.d 


# Each subdirectory must supply rules for building sources it contributes
Application/User/%.o: ../Application/User/%.c Application/User/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m4 -std=gnu11 -g3 -DDEBUG -DARM_MATH_CM4 -DUSE_HAL_DRIVER -DSTM32F303xE -c -I../Inc -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/Core/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/DSP/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.0/Drivers/CMSIS/NN/Include" -I../Drivers/STM32F3xx_HAL_Driver/Inc -I../Drivers/STM32F3xx_HAL_Driver/Inc/Legacy -I../Drivers/CMSIS/Device/ST/STM32F3xx/Include -I../Drivers/CMSIS/Include -I"C:/Users/User/Desktop/thesis images/Nitramon_V1.0/Nitramon_V1.0/Application/User" -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" --specs=nano.specs -mfpu=fpv4-sp-d16 -mfloat-abi=hard -mthumb -o "$@"

clean: clean-Application-2f-User

clean-Application-2f-User:
	-$(RM) ./Application/User/PeripheralInit.d ./Application/User/PeripheralInit.o ./Application/User/UserFunctions.d ./Application/User/UserFunctions.o

.PHONY: clean-Application-2f-User

