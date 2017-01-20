// connect motor controller pins to Arduino digital pins
#include <SoftwareSerial.h>
#include <Servo.h>
#include "Arduino_PinConfiguration.h"
#include "MotorDriver_Control.h"
#include "ProximitySensor.h"
#include "Xbee.h"

static int CycleNumber;

void setup()
{
  Servo_init();
  Xbee_init();
  Prox_init();
  MotorDriver_Init();
  CycleNumber = 1;
}

void loop()
{
  unsigned long time;
  time = micros();
    char controlsignal;
    controlsignal = Read_Xbee_input();
    Xbee_Flush();
    MotorDriver_Control(controlsignal);
    Servo_Control(controlsignal);
    Prox_Measure();
    CycleNumber = CycleNumber + 1;
    if (CycleNumber == 10){
      Xbee_SendOutput(Prox_Output());
      CycleNumber = 1;
    }
  time = micros() - time;
  delay(100-time/1000);
}
