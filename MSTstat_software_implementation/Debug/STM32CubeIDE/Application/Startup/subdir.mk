################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (9-2020-q2-update)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
S_SRCS += \
../STM32CubeIDE/Application/Startup/startup_stm32f303zetx.s 

OBJS += \
./STM32CubeIDE/Application/Startup/startup_stm32f303zetx.o 

S_DEPS += \
./STM32CubeIDE/Application/Startup/startup_stm32f303zetx.d 


# Each subdirectory must supply rules for building sources it contributes
STM32CubeIDE/Application/Startup/%.o: ../STM32CubeIDE/Application/Startup/%.s STM32CubeIDE/Application/Startup/subdir.mk
	arm-none-eabi-gcc -mcpu=cortex-m4 -g3 -DDEBUG -c -x assembler-with-cpp -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" --specs=nano.specs -mfpu=fpv4-sp-d16 -mfloat-abi=hard -mthumb -o "$@" "$<"

clean: clean-STM32CubeIDE-2f-Application-2f-Startup

clean-STM32CubeIDE-2f-Application-2f-Startup:
	-$(RM) ./STM32CubeIDE/Application/Startup/startup_stm32f303zetx.d ./STM32CubeIDE/Application/Startup/startup_stm32f303zetx.o

.PHONY: clean-STM32CubeIDE-2f-Application-2f-Startup

