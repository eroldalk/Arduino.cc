#include <LCD5110_Graph.h>

LCD5110 myGLCD(8,9,10,11,12);

extern uint8_t SmallFont[];

int y;

void setup()
{
  myGLCD.InitLCD();
  myGLCD.setFont(SmallFont);
  randomSeed(analogRead(0));
}

void loop()
{
  y = random(0, 40);
  for (int i=84; i>=-(34*6); i--)
  {
    myGLCD.print("EROL DALKILIC  :) SOFTWARE DEVELOPER  :)", i, y);
    
    myGLCD.update();
    delay(50);
  }
}
