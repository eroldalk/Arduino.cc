int analogPin = A0;

void setup() {
 Serial.begin(9600);
}

void loop() {
  int okunanDeger = analogRead(analogPin);
  Serial.println(okunanDeger);
  delay(100);
}
