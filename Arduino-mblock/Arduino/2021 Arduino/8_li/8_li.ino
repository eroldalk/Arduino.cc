const int ledpin[]= {2,3,4,5,6,7,8,9};

void setup() {
 //2-9 arası pinler çıkış olarak yüklendirildi
for(int i=0; i<8; i++)
pinMode(ledpin[i],OUTPUT);
}

void loop() {
//ilk 4 bit sönük son 4 bit yanık
 for(int i=0; i<8; i++)
{
  if(i<4)digitalWrite(ledpin[i],LOW);
  else digitalWrite(ledpin[i],HIGH);
 
}
delay(500);
//ilk 4 bit sönük son 4 bit yanık
 for(int i=0; i<8; i++)
 {
   if(i<4)digitalWrite(ledpin[i],HIGH);
  else digitalWrite(ledpin[i],LOW);
 }
 delay(500);
}//loop sonu
 
