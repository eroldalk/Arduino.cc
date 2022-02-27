int led=8;


void setup() {
  pinMode(led,OUTPUT);
}

void loop() {

  digitalWrite(led,HIGH); // 5V'a çektik 
  delay(1000);//1000ms = 1 sn
digitalWrite(led,LOW); // 0V'a çektik 
  delay(1000); //1000ms = 1 sn

}
