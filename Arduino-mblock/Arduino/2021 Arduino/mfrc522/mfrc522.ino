//Viral Science
//RFID
#include <SPI.h>
#include <MFRC522.h>

int led=8;
#define SS_PIN 10
#define RST_PIN 9
#define LED_G 4 //define green LED pin
#define LED_R 5 //define red led
#define BUZZER 2 //buzzer pin
MFRC522 mfrc522(SS_PIN, RST_PIN);  //create MFRC522 instance.



void setup() {
  Serial.begin(9600);  // Initiate a serial communication
  SPI.begin();       // Initiate SPI bus
  mfrc522.PCD_Init(); // Initiate MFRC522
  pinMode(LED_G, OUTPUT);
  pinMode(LED_R, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  noTone(BUZZER);
  Serial.println("put your card to the reader...");
  Serial.println();
 pinMode(led, OUTPUT);
}

void loop() 
{

//Look for new carda
if( ! mfrc522.PICC_IsNewCardPresent())
{
  return;
  }
 //select one of the carda
 if( ! mfrc522.PICC_ReadCardSerial())
 {
  return;
  }

 //Show UID on serial monitör
 Serial.print("UID tag :"); 
 String content= "";
 byte letter;
     delay(500);
 for (byte i = 0; i < mfrc522.uid.size; i++)
 {
  Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? "0" : " ");
  Serial.print(mfrc522.uid.uidByte[i], HEX);
  content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? "0" : " "));
  content.concat(String(mfrc522.uid.uidByte[i], HEX));

}

Serial.println();
Serial.print("message ");
content.toUpperCase();
if(content.substring(1) == "39 2006 B3"|| content.substring(1) == "4A 5D 8A 80" ) //change here the UID of the card/cards that you want to give access
{
  Serial.println("Authorized access");
  Serial.println();
  delay(500);
  digitalWrite(LED_G, HIGH);
  //tone(BUZZER, 500);
  delay(300);
  noTone(BUZZER);
 digitalWrite(led, HIGH);
  delay(1000);
  digitalWrite(led, LOW);
  delay(1000);
}
else{
  Serial.println("access denied");
  digitalWrite(LED_R, HIGH);
  tone(BUZZER, 300);
  delay(100);
  digitalWrite(LED_R, LOW);
   noTone(BUZZER);
 }

}
