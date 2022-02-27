int butonPin = 8;
int ledPin = 9;

int kalicibuton = 0;

void setup()
{
  pinMode(butonPin, INPUT);
  pinMode(ledPin, OUTPUT);
}

void loop()
{
  if(digitalRead(butonPin) == 1)
  {
    if(kalicibuton == 0)
    {
      kalicibuton = 1;
    }
    else
    {
      kalicibuton = 0;
    }
  }

  if(kalicibuton == 1)
  {
    digitalWrite(ledPin, HIGH);
  }
  else
  {
    digitalWrite(ledPin, LOW);
  }

  delay(200);
}
