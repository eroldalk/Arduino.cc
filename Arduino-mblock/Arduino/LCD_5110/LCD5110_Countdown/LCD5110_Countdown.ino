#include <LCD5110_Basic.h>

LCD5110 myGLCD(8,9,10,11,12);

extern uint8_t SmallFont[];
extern uint8_t MediumNumbers[];

void setup()
{
  myGLCD.InitLCD();
}

void loop()
{
  myGLCD.setFont(SmallFont);
  myGLCD.clrScr();
  myGLCD.print("Entering", CENTER, 0);
  myGLCD.print("Sleep Mode", CENTER, 8);
  myGLCD.print("in", CENTER, 16);
  myGLCD.print("Seconds", CENTER, 40);

  myGLCD.setFont(MediumNumbers);
  for (int s=10; s>=0; s--)
  {
    myGLCD.printNumI(s, CENTER, 24, 2, '0');
    delay(1000);
  }
  
  myGLCD.enableSleep();

  delay(5000);
  myGLCD.disableSleep();
  myGLCD.setFont(SmallFont);
  myGLCD.print("Awake again!", CENTER, 0);
  myGLCD.print("The screen was", CENTER, 16);
  myGLCD.print("cleared while", CENTER, 24);
  myGLCD.print("in Sleep Mode.", CENTER, 32);
  delay(5000);
}
