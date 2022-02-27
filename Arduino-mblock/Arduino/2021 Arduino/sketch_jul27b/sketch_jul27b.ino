
int ledkirmizi = 8;
int ledmavi = 9;
int ledyesil = 10;


int sayac = 0;

void setup()
{
  pinMode(ledkirmizi, OUTPUT);
  pinMode(ledmavi, OUTPUT);
  pinMode(ledyesil, OUTPUT);
  

}

void loop()
{

  if (sayac == 0)
  
  {

    digitalWrite(ledyesil, HIGH);
    digitalWrite(ledmavi, LOW);
    digitalWrite(ledkirmizi, LOW);
    sayac = 1;
    delay(100);
  }
  else if (sayac == 1)
  {
    digitalWrite(ledyesil, LOW);
    digitalWrite(ledmavi, HIGH);
    digitalWrite(ledkirmizi, LOW);
    sayac = 2;
    delay(100);

  }
  else
  {
    digitalWrite(ledyesil, LOW);
    digitalWrite(ledmavi, LOW);
    digitalWrite(ledkirmizi, HIGH);
    sayac = 0;
    delay(100);



  }
  
 
}
