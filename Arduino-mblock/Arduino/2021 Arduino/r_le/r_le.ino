#define role 8
void setup() 
{ 
pinMode(role, OUTPUT);
} 
void loop() 
{ 
digitalWrite(role,LOW);
delay(2000);
digitalWrite(role,HIGH);
delay(2000);
}
