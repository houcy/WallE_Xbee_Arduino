#include <Servo.h>
#include "ServoControl.h"

Servo myservo;
static int CameraPosition;
static int Calibration;
void Servo_init(){
	myservo.attach(ARDUINO_PORT9);
	myservo.write(CAMERA_POS);
  CameraPosition = 90;
  Calibration = 0;
}

void Servo_Control(char controlsignal) {
    switch (controlsignal){
      case 'j': /* turing right */
          CameraPosition -= 1;
          if (CameraPosition < 40) {
            CameraPosition = 40;
          }
          break;
      case 'k':
          CameraPosition += 1;
          if (CameraPosition > 140) {
            CameraPosition = 140;
          }
          break;
      case 'p':
          myservo.write(40);
          delay(750);
          myservo.write(140);
          delay(750);
          break; 
      default:
          //CameraPosition = 90;
          break;     
    }
    myservo.write(CameraPosition+Calibration);
}
