#include "Arduino_PinConfiguration.h"
#define PROX_TRIG ARDUINO_PORT13
#define PROX_ECHO ARDUINO_PORT10

void Prox_init();
void Prox_Measure();
String Prox_Output();
