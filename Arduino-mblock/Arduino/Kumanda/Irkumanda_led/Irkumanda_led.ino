#include <IRremote.h>

IRrecv irrecv(2);

decode_results results;

#define OK 3924233868






void setup() 
{
  Serial.begin(9600);
  irrecv.enableIRIn();
  pinMode(3, OUTPUT);
  digitalWrite(3, LOW);
}

void loop() 
{
  if (irrecv.decode(&results))
  {
    Serial.println(results.value);
    if(results.value == OK)
    digitalWrite( 3, !digitalRead(3));
    irrecv.resume();
  }
   
}
