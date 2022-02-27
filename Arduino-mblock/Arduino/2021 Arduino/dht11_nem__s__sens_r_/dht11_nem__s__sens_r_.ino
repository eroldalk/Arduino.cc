#include <DHT.h>

int dhtPin = 2;
int ledPin = 8;

DHT dht(dhtPin, DHT11);

void setup()
{
  dht.begin();
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  float nem = dht.readHumidity();
  float sicaklik = dht.readTemperature();

  Serial.print("Nem ");
  Serial.print(nem);
  Serial.print("% ");

  Serial.print("Sıcaklık ");
  Serial.print(sicaklik);
  Serial.println("*C");

  if(sicaklik>50)
  {
    digitalWrite(ledPin, HIGH);
  }
  else
  {
    digitalWrite(ledPin, LOW);
  }

  delay(500);
}
