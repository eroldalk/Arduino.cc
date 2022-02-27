void setup() {

Serial.begin(9600);
}

void loop() {

int toplam = topla(3,5);  
Serial.println(toplam);

delay(1000);

}

int topla(int a,int b)
{
  int c=a+b;
  return c;
}
