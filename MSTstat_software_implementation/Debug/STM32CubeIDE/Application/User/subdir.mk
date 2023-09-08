################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (9-2020-q2-update)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../STM32CubeIDE/Application/User/syscalls.c \
../STM32CubeIDE/Application/User/sysmem.c 

OBJS += \
./STM32CubeIDE/Application/User/syscalls.o \
./STM32CubeIDE/Application/User/sysmem.o 

C_DEPS += \
./STM32CubeIDE/Application/User/syscalls.d \
./STM32CubeIDE/Application/User/sysmem.d 


# Each subdirectory must supply rules for building sources it contributes
STM32CubeIDE/Application/User/%.o: ../STM32CubeIDE/Application/User/%.c STM32CubeIDE/Application/User/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m4 -std=gnu11 -g3 -DDEBUG -DARM_MATH_CM4 -DUSE_HAL_DRIVER -DSTM32F303xE -c -I../Inc -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.3/Drivers/CMSIS/Core/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.3/Drivers/CMSIS/DSP/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.3/Drivers/CMSIS/Include" -I"C:/Users/User/STM32Cube/Repository/STM32Cube_FW_F3_V1.11.3/Drivers/CMSIS/NN/Include" -I"C:/Users/User/Desktop/thesis images/Nitramon_V1.0/Nitramon_V1.0/STM32CubeIDE/Application" -I../Drivers/STM32F3xx_HAL_Driver/Inc -I../Drivers/STM32F3xx_HAL_Driver/Inc/Legacy -I../Drivers/CMSIS/Device/ST/STM32F3xx/Include -I../Drivers/CMSIS/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" --specs=nano.specs -mfpu=fpv4-sp-d16 -mfloat-abi=hard -mthumb -o "$@"

clean: clean-STM32CubeIDE-2f-Application-2f-User

clean-STM32CubeIDE-2f-Application-2f-User:
	-$(RM) ./STM32CubeIDE/Application/User/syscalls.d ./STM32CubeIDE/Application/User/syscalls.o ./STM32CubeIDE/Application/User/sysmem.d ./STM32CubeIDE/Application/User/sysmem.o

.PHONY: clean-STM32CubeIDE-2f-Application-2f-User

