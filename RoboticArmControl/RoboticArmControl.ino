// constants won't change. Used here to set a pin number :
const int PWMA = 3;
const int AIN1 = 4;
const int AIN2 = 5;
const int STNDBY = 7;
const int PWMB = 10;
const int BIN1 = 8;
const int BIN2 = 9;
const int Encoder1 = A0;
const int Encoder2 = A1;
const int GrapplerCircuitBreaker = 13;
const int ElbowCircuitBreaker = 12;
int EncoderValue = 1;
int increment=1;

void setup() {
  // set the digital pin as output:
  pinMode(PWMA, OUTPUT);
  pinMode(AIN1, OUTPUT);
  pinMode(AIN2, OUTPUT);
  pinMode(PWMB, OUTPUT);
  pinMode(BIN1, OUTPUT);
  pinMode(BIN2, OUTPUT);
  pinMode(STNDBY, OUTPUT);
  digitalWrite(PWMA, HIGH);
  digitalWrite(PWMB, HIGH);
  digitalWrite(STNDBY, HIGH);
  pinMode(Encoder1, INPUT);
  pinMode(Encoder2, INPUT);
  pinMode(11, OUTPUT);
  pinMode(GrapplerCircuitBreaker,INPUT);
  pinMode(ElbowCircuitBreaker,INPUT);
  digitalWrite(AIN1, HIGH);
  digitalWrite(AIN2, LOW);
  delay(500);
}

void Grappler(boolean Grab_TRUE_Release_False){
  if (Grab_TRUE_Release_False){ //Grab
    digitalRead(GrapplerCircuitBreaker);
    while(digitalRead(GrapplerCircuitBreaker) != HIGH){
      digitalWrite(AIN1, HIGH);
      digitalWrite(AIN2, LOW);
    }
  } else { //Release
    digitalRead(GrapplerCircuitBreaker);
    while(digitalRead(GrapplerCircuitBreaker) != HIGH){
      digitalWrite(AIN1, LOW );
      digitalWrite(AIN2, HIGH);
    }
  }
    
}

void Elbow(){
    digitalWrite(BIN1, LOW);
    digitalWrite(BIN2, LOW);
}
void loop() {
 
    EncoderValue = analogRead(A0);
    analogWrite(11,EncoderValue);
    //Grappler(true);
    digitalWrite(AIN1, HIGH);
      digitalWrite(AIN2, LOW);
    delay(50);
    digitalWrite(AIN1, LOW);
      digitalWrite(AIN2, LOW);
      delay(1000);
    /*
    digitalWrite(AIN1, LOW);
    digitalWrite(AIN2, HIGH);
    digitalWrite(BIN1, LOW);
    digitalWrite(BIN2, LOW);
    delay(1000);*/
    
}

