int input; //number inputing variable


void setup()
{
  // The pinmodes of the pins 11, 10 and 6 are set to high. Serial port 9600 is started and the welcome message is printed.
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(6, OUTPUT);
  Serial.begin(9600);
  Serial.println("YOU SUCK! but enter in the number of LED's you wanna turn on.");
}


void loop()
{
while (Serial.available())  //detecting what the input is
{
  input = Serial.parseInt(); //collect the int from the serail moniter and what u inputted //all parse does it conver the input to int

  if(input == 1) //when "1" is typed it turns on one lED
  {
    digitalWrite(11, HIGH);
  }
  
  else if(input == 2) //when "2" is typed it turns on first two LED's
  {
  digitalWrite(11, HIGH);
  digitalWrite(10, HIGH);
  }
  
   else if(input == 3) //when "3" is typed it turns on all three LED's
  {
  digitalWrite(11, HIGH);
  digitalWrite(10, HIGH);
  digitalWrite(6, HIGH);
  }
  
  else //when anythign else is typed, it turns off all LED's
  {
   digitalWrite(11, LOW);
  digitalWrite(10, LOW);
  digitalWrite(6, LOW);
  }
}
}