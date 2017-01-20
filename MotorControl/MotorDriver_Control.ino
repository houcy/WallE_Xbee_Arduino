#include <SoftwareSerial.h>
#include <Servo.h>
#include "Arduino_PinConfiguration.h"
#include "MotorDriver_PinConfiguration.h"
#define SPEED 150

void LeftSide_PIN_B_ENABLED_Forward(){
	digitalWrite(MotorDrive_PIN3, LOW);
	digitalWrite(MotorDrive_PIN4, HIGH);
}
void LeftSide_PIN_B_ENABLED_Backward(){
	digitalWrite(MotorDrive_PIN3, HIGH);
	digitalWrite(MotorDrive_PIN4, LOW);
}
void RightSide_PIN_A_ENABLED_Forward(){
	digitalWrite(MotorDrive_PIN1, HIGH);
	digitalWrite(MotorDrive_PIN2, LOW);
}
void RightSide_PIN_A_ENABLED_Backward(){
	digitalWrite(MotorDrive_PIN1, LOW);
	digitalWrite(MotorDrive_PIN2, HIGH);
}
void goForward()
{
	LeftSide_PIN_B_ENABLED_Forward();
	RightSide_PIN_A_ENABLED_Forward();
}
void goBackward()
{
	LeftSide_PIN_B_ENABLED_Backward();
	RightSide_PIN_A_ENABLED_Backward();
}
void turnLeft()
{
	LeftSide_PIN_B_ENABLED_Backward();
	RightSide_PIN_A_ENABLED_Forward();
}
void turnRight()
{
	LeftSide_PIN_B_ENABLED_Forward();
	RightSide_PIN_A_ENABLED_Backward();
}
void Stop(){
    digitalWrite(MotorDrive_PIN1, LOW);
    digitalWrite(MotorDrive_PIN2, LOW);
    digitalWrite(MotorDrive_PIN3, LOW);
    digitalWrite(MotorDrive_PIN4, LOW);
}
void setSpeed(){
  	analogWrite(MotorDrive_EN_A,SPEED);
  	analogWrite(MotorDrive_EN_B,SPEED);
}

void MotorDriver_Init(){
    // set all the motor control pins to outputs
  pinMode(MotorDrive_EN_A, OUTPUT);
  pinMode(MotorDrive_EN_B, OUTPUT);
  pinMode(MotorDrive_PIN1, OUTPUT);
  pinMode(MotorDrive_PIN2, OUTPUT);
  pinMode(MotorDrive_PIN3, OUTPUT);
  pinMode(MotorDrive_PIN4, OUTPUT);
}

void MotorDriver_Control(char control_signal){
   boolean isStop = 1;
   switch (control_signal){
      case 'w': 
        goForward();
        Xbee_SendOutput("Forward!");
        break;
      case 's': 
        goBackward();
        Xbee_SendOutput("Retreat!");
        break;
      case 'd': 
        turnRight();
        Xbee_SendOutput("Going Right!");
        break;
      case 'a': 
        turnLeft();
        Xbee_SendOutput("Going Left!");
        break;
      default:
        Stop();
   }
   setSpeed();
}

