int btn = 0;
void setup()
{
  pinMode(13,OUTPUT);
  pinMode(4,INPUT);
}

void loop()
{
  btn = digitalRead(4);
  
  if (btn == HIGH)
  {
  digitalWrite(13,HIGH);
  }
  else
  {
  digitalWrite(13,LOW);
  }
}