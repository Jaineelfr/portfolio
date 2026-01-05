int sensorVal = 0; //variable to hold value from potentiometer
int mappedVal = 0; 

void setup() 
{
  pinMode(11, OUTPUT);
  pinMode(A0, INPUT);
}


void loop()
{
  sensorVal = analogRead(A0);//read from pot
  mappedVal = map(sensorVal,0,1024,0,255); //map the value for pot
  analogWrite(11,mappedVal);
}

