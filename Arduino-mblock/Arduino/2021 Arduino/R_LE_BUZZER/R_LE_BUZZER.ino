int buzzerPin = 10;
int LDRPin = 0;
void setup()
{
}
void loop()
{
  int deger = analogRead(LDRPin);
  int pitch = 10000 + deger / 10;
  tone(buzzerPin, pitch);
}
