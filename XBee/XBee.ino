#include <SoftwareSerial.h>
SoftwareSerial Xbee(11,12);
void setup() {
        Xbee.begin(9600);     // opens serial port, sets data rate to 9600 bps
        Xbee.print("Hello!!!");
}

void loop() {

 if (Xbee.available()) {   // is there any information available on serial port ?
  Xbee.print("I received something!");
  Xbee.println(char(Xbee.read()));
 }
}
