// Motor 1
int pwmB = 6;
int in1B = 7;
int in2B = 8;
int pwmA = 5;
int in1A = 3;
int in2A = 4;
int motorspeed = 0;
int usernum = 0;

void setup()

{

  // Set all the motor control pins to outputs
  pinMode(pwmB, OUTPUT);
  pinMode(in1B, OUTPUT);
  pinMode(in2B, OUTPUT);
  pinMode(pwmA, OUTPUT);
  pinMode(in1A, OUTPUT);
  pinMode(in2A, OUTPUT);
  Serial.begin(9600);
  Serial.println("Choose a number between 1-9");
}

void loop() {
  motorspeed = 255;
  analogWrite(pwmA, motorspeed);
  analogWrite(pwmB, motorspeed);
  while (Serial.available()) {
    usernum = Serial.parseInt();

    if (usernum == 1)  //FIRST FORWARD
    {
      forward();
    }

    
    else if (usernum == 2)  //FIRST FORWARD
    {
      right();
    }

    
   else if (usernum == 3)  //FIRST FORWARD
    {
      left();
    }

    
   else if (usernum == 4)  //FIRST FORWARD
    {
      backward();
    }

   
   else  //FIRST FORWARD
    {
      stop();
    }
  }
  delay(100);
}

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
