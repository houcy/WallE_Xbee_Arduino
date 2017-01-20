#include <SoftwareSerial.h>
#include <Servo.h>
#include "Arduino_PinConfiguration.h"
#include "MotorDriver_PinConfiguration.h"

void LeftSide_PIN_B_ENABLED_Forward();
void LeftSide_PIN_B_ENABLED_Backward();
void RightSide_PIN_A_ENABLED_Forward();
void RightSide_PIN_A_ENABLED_Backward();
void goForward();
void goBackward();
void turnLeft();
void turnRight();

void MotorDriver_Init();
void MotorDriver_Control(char control_signal);
void setSpeed();
void Stop();
