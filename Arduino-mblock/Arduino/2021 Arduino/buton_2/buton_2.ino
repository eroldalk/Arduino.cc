int butonPin = 8;
int ledPin = 9;

void setup()
{
  pinMode(butonPin, INPUT);
  pinMode(ledPin, OUTPUT);
}

void loop()
{
  if(digitalRead(butonPin) == 1)
  {
    digitalWrite(ledPin, HIGH);
  }
  else
  {
    digitalWrite(ledPin, LOW);
  }

  delay(100);
}
