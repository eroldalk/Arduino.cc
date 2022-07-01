int ldr = 0;
 void setup() {
   Serial.begin(9600);
 }
 void loop() {
   int deger = analogRead(ldr);  
   Serial.println(deger);        
   delay(1000);
 }
