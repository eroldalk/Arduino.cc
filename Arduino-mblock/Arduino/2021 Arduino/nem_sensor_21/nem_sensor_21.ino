#include<dht.h>

dht sensor;

#define dhtPin 2

float nem;
float sicaklik;


void setup()
{
 
  Serial.begin(9600);
}

void loop()
{
  sensor.read21.humdity;

  nem = sensor.temperature
  
  Serial.print("Nem : ");
  Serial.print(nem);
  Serial.print(" %");
  
  Serial.print("-");

  Serial.print("Sıcaklık : ");
  Serial.print(sicaklik);
  Serial.print(" C");

  Serial.println("****************************");

  delay(2000);
}
