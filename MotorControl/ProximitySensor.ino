#include <SoftwareSerial.h>
#include "Arduino_PinConfiguration.h"
#include "ProximitySensor.h"

long duration;
long distance;
  
void Prox_init(){
	pinMode(PROX_TRIG, OUTPUT);
  pinMode(PROX_ECHO, INPUT);
}

void Prox_Measure(){
  digitalWrite(PROX_TRIG, LOW);
  delayMicroseconds(2);
  digitalWrite(PROX_TRIG, HIGH);
  delayMicroseconds(10);
  digitalWrite(PROX_TRIG, LOW);
  duration = pulseIn(PROX_ECHO, HIGH);
  distance = ((duration/2)/29.1);
}

String Prox_Output(){
  String ReturnValue;
  ReturnValue = String(distance);
  String ReturnLength;
  ReturnLength = ReturnValue.length();
  ReturnValue = ReturnLength + ReturnValue;
  return ReturnValue;
}

