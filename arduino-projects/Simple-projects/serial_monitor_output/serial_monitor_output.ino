int sensorVal = 0; //variable to hold value from potentiometer
int mappedVal = 0; //variable for the mapped value for LED brightness

int btnState = 0; //variable to hold state of the button
int btnPin = 2; //variable for the pin reading the button

//variable for LED pins
int btnLedPin = 10;
int potPin = 11;

void setup()
{
  Serial.begin(9600); //Initialize serial monitor 
  pinMode(potPin, OUTPUT); //set up ~pwm pin for potent
  pinMode(btnLedPin, OUTPUT); //set up digital pin for button
  
  //set up input pins
  pinMode(A0, INPUT);
  pinMode(btnPin, INPUT);
  //end of void loop
}

void loop()
{
  //link the potentiometer to the orange LED
  sensorVal = analogRead(A0); //read from pot
  mappedVal = map (sensorVal, 0, 1024, 0, 255); //map the value
  analogWrite (potPin, mappedVal); //write mapped value to the orange LED
  
  
  
  //link the button to the green LED using digitalRead + if state
  btnState = digitalRead(btnPin);
  if (btnState == HIGH)//is the button being pressed
  {
  digitalWrite (btnLedPin, HIGH);
  Serial.println ("PRESSED");
  }
  else //button not pressed
  {
  digitalWrite(btnLedPin, LOW);
      Serial.println ("NOT PRESSED");
  }
  
  //end of void loop
  

}
