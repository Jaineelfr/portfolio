// C++ code
//
int brightness = 0;
int red = 9;
int red2 = 11;
int green = 10;
int white = 6;
int Yellow = 3;
void setup()
{
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(11,OUTPUT);

}

void loop()
{
  //First LED
  for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(red,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(red,brightness);
    delay(30);
  }
  delay(10);






//second lED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(red2,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(red2,brightness);
    delay(30);
  }
  delay(10);
  






 //thired LED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(green,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(green,brightness);
    delay(30);
  }
  delay(10);







  //fourth LED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(white,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(white,brightness);
    delay(30);
  }
  delay(10);






  //fifth LED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(Yellow,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(Yellow,brightness);
    delay(30);
  }
  delay(10);






  //repeating back
  //fifth LED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(Yellow,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(Yellow,brightness);
    delay(30);
  }
  delay(10);



    //fourth LED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(white,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(white,brightness);
    delay(30);
  }
  delay(10);







 //thired LED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(green,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(green,brightness);
    delay(30);
  }
  delay(10);






//second lED
    for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(red2,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(red2,brightness);
    delay(30);
  }
  delay(10);



    //First LED
  for(brightness = 0; brightness <= 255; brightness += 5)
  {
analogWrite(red,brightness);
    delay(30);
  }
  for (brightness = 255; brightness >= 0; brightness -= 5)
  {
  analogWrite(red,brightness);
    delay(30);
  }
  delay(10);
}