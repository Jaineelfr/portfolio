// Motor 1
int pwmB = 6;
int in1B = 7;
int in2B = 8;
//motor 1
int pwmA = 5;
int in1A = 3;
int in2A = 4;
int motorspeed = 0;
int usernum = 0;---
//irsensor
int sensorLeft = A1;
int sensorCenter = A2;
int sensorRight = A3;
//potentiometer
int Potpin = A0;

//backlights
int redright = 12;
  int redleft = 9;
void setup()
{
  //Set led pins as output
 pinMode(12, OUTPUT);
   pinMode(9, OUTPUT);
  // Set all the motor control pins to outputs
  pinMode(pwmB, OUTPUT);
  pinMode(in1B, OUTPUT);
  pinMode(in2B, OUTPUT);
  pinMode(pwmA, OUTPUT);
  pinMode(in1A, OUTPUT);
  pinMode(in2A, OUTPUT);

  Serial.begin(9600);

  // Set the sensor pins as input
  pinMode(sensorLeft, INPUT);
  pinMode(sensorCenter, INPUT);
  pinMode(sensorRight, INPUT);
}

void loop() {

  potspeed();

//setting motorspeed output
  analogWrite(pwmA, motorspeed);
  analogWrite(pwmB, motorspeed-27);



  //IR sensor
  int leftValue = digitalRead(sensorLeft);
  int centerValue = digitalRead(sensorCenter);
  int rightValue = digitalRead(sensorRight);


  // Print the sensor values for debugging
  Serial.print("Left Sensor: ");
  Serial.print(leftValue);
  Serial.print(" | Center Sensor: ");
  Serial.print(centerValue);
  Serial.print(" | Right Sensor: ");
  Serial.println(rightValue);



  // Decision logic based on digital values (HIGH or LOW)
  if (leftValue == LOW && centerValue == HIGH && rightValue == HIGH) {
    Serial.println("Turn Left");
    left();
    digitalWrite(redright, LOW);
  digitalWrite(redleft, HIGH);
  } 
  else if (leftValue == HIGH && centerValue == LOW && rightValue == HIGH) {
    Serial.println("Straight");
    forward();
    digitalWrite(redright, HIGH);
  digitalWrite(redleft, HIGH);

  } 
  else if (leftValue == HIGH && centerValue == HIGH && rightValue == LOW ) {
    Serial.println("Turn Right");
    right();
    digitalWrite(redright, HIGH);
  digitalWrite(redleft, LOW);
  } 
  else {
    Serial.println("Off Line");
    stop();
  }

  // Add a small delay
  delay(100);
}


//Suroutines
void forward() {

  digitalWrite(in2A, LOW);
  digitalWrite(in1A, HIGH);
  digitalWrite(in2B, HIGH);
  digitalWrite(in1B, LOW);
}

void left() {

  digitalWrite(in2A, HIGH);
  digitalWrite(in1A, LOW);
  digitalWrite(in2B, HIGH);
  digitalWrite(in1B, LOW);
}

void right() {

  digitalWrite(in2A, LOW);
  digitalWrite(in1A, HIGH);
  digitalWrite(in2B, LOW);
  digitalWrite(in1B, HIGH);
  
}

void backward() {
  digitalWrite(in2A, HIGH);
  digitalWrite(in1A, LOW);
  digitalWrite(in2B, LOW);
  digitalWrite(in1B, HIGH);
}

void stop() {

  digitalWrite(in2A, LOW);
  digitalWrite(in1A, LOW);
  digitalWrite(in2B, LOW);
  digitalWrite(in1B, LOW);
}

void potspeed()
{
   int potValue = analogRead(Potpin);
  // Map the potentiometer value to the range of motor speed (0-255)
  motorspeed = map(potValue, 0, 1023, 0, 255);

}