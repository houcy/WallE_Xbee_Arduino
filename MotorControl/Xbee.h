#include <SoftwareSerial.h>
SoftwareSerial Xbee(11,12);

void Xbee_init();
char Read_Xbee_input();
void Xbee_SendOutput();
void Xbee_Flush();
