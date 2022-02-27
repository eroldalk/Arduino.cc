#include<Servo.h>

Servo servol;

void setup() 
{
 servol.attach(10);//Data Ucu
}

void loop() 
{
  for(int i = 0; i<=180; i++)
  {
    servol.write(i);
    delay(50);
    }
    for(int i=179; i>=0; i--)
    {
      servol.write(i);
    delay(50);
      
      }
  
  
}
