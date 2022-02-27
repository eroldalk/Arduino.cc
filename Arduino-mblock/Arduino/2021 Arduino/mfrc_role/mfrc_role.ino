#include <SPI.h>

#include <MFRC522.h>

 

#define RST_PIN         9           // rst pini seçimi

#define SS_PIN          10          // ss pini seçimi

 

MFRC522 mfrc522(SS_PIN, RST_PIN);   // Create MFRC522 instance.

 

String read_rfid;                   // okunan rfis kart değişkeni

String ok_rfid_1="4a5d8a80";        // 1. Kart numarası ( sizler kendi kart numaralarınızı girmelisiniz )

String ok_rfid_2="39206b3";        //  2. Kart numarası  ( sizler kendi kart numaralarınızı girmelisiniz )

int lock = 8;                       // Röle pini

/*

* Kurulum yapılıyor

*/

void setup() {

Serial.begin(9600);         // seri iletişim ayarı

SPI.begin();                // SPI iletişim ayarı

mfrc522.PCD_Init();         // MFRC522 kart okuyucu ayarı

 

//Röle pini ayarı

pinMode(lock, OUTPUT);

 

}

/*

* İlk kart okuma kısmı bura da okunan kart numarasını 1. Ve 2. Kart olarak eklemeniz gereklidir.

*/

void dump_byte_array(byte *buffer, byte bufferSize) {

read_rfid="";

for (byte i = 0; i < bufferSize; i++) {

read_rfid=read_rfid + String(buffer[i], HEX);

}

}

 

void open_lock() {

//Kapı otomatiğini Röle yi 500 ms açık tut

digitalWrite(lock,HIGH);

delay(500);

digitalWrite(lock,LOW);

}

 

 

 

 

void loop() {

 

// kart oku

if ( ! mfrc522.PICC_IsNewCardPresent())

return;

 

// kart seçimi

if ( ! mfrc522.PICC_ReadCardSerial())

return;

 

dump_byte_array(mfrc522.uid.uidByte, mfrc522.uid.size);

Serial.println(read_rfid);

if (read_rfid==ok_rfid_1) {

//eğer kart numarası uyarsa röleyi çek

open_lock();

}

if (read_rfid==ok_rfid_2) {

//eğer kart numarası uyarsa röleyi çek

open_lock();

}

}
