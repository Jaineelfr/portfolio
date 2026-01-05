int sensorLeft = A1;
int sensorCenter = A2;
int sensorRight = A3;

void setup() {
  Serial.begin(9600);
  
  // Set the sensor pins as input
  pinMode(sensorLeft, INPUT);
  pinMode(sensorCenter, INPUT);
  pinMode(sensorRight, INPUT);
}

void loop() {
  // Read the sensor values
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
  }
  else if (rightValue == LOW && centerValue == HIGH && leftValue == HIGH) {
    Serial.println("Turn Right");
  }
  else if (centerValue == LOW && leftValue == HIGH && rightValue == HIGH) {
    Serial.println("Straight");
  }
  else {
    Serial.println("Off Line");
  }

  // Add a small delay to avoid overwhelming the serial output
  delay(100);
}