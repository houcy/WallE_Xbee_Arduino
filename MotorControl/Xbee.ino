#include <SoftwareSerial.h>

void Xbee_init(){
	Xbee.begin(9600);     // opens serial port, sets data rate to 9600 bps
	Xbee.println("Xbee fired up! Ready to Transmit!!!");
}

char Read_Xbee_input(){
	if(Xbee.available()){
		return char(Xbee.read());
	} else {
    return ' ';
	}
}

void Xbee_SendOutput(String output_string){
  Xbee.println(output_string);
}

void Xbee_Flush(){
  Xbee.flush();
}

