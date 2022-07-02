#define kirmizi 8
#define yesil 9
#define mavi 10
 void setup() { 
   
   Serial.begin(9600);
 }
 void loop() {
 if (Serial.available() == 3)
   {
     analogWrite(kirmizi, 255 - Serial.read());
     analogWrite(yesil, 255 - Serial.read());
     analogWrite(mavi, 255 - Serial.read());
    
    }
 }





 
