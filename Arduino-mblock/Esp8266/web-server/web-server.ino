#include <ESP8266WiFi.h>
#include <ESP8266WebServer.h>
#include "DHT.h"

#define DHTTYPE DHT11   // DHT 11

/*Put your SSID & Password*/
const char* ssid = "TurkTelekom_ZTD5XZ_2.4GHz";  //Wifi adınız
const char* password = "s94yNA7tzDDU";  //wifi şifreniz

ESP8266WebServer server(80); //80 portunu kullanarak bir web server nesnesi oluşturduk

uint8_t DHTPin = D4;
uint8_t LED1pin = D2;
bool LED1status = LOW; //durumlarını tanımlıyoruz.
uint8_t LED2pin = D3;
bool LED2status = LOW;
               
// DHT'yi tanımlıyoruz..
DHT dht(DHTPin, DHTTYPE);                

float Temperature;
float Humidity;
 
void setup() {
  Serial.begin(115200);
  delay(100);
  
  pinMode(DHTPin, INPUT);
  pinMode(LED1pin, OUTPUT);
  pinMode(LED2pin, OUTPUT);

  dht.begin();              

  Serial.println("wifi'ya bağlanılıyor ");
  Serial.println(ssid);

  //yerel ağınıza bağlanmanız için gerekli komut
  WiFi.begin(ssid, password);

  //bağlantı gerçekleştiğini kontrol ediyoruz
  while (WiFi.status() != WL_CONNECTED) {
  delay(1000);
  Serial.print("."); //bağlantı sağlanana kadar ekranda "." çıkmasını sağlıyoruz.(Loading gibi)
  }
  Serial.println("");
  Serial.println("WiFi Bağlandı..!");
  Serial.print("IP Adresiniz: ");  Serial.println(WiFi.localIP());

  server.on("/", handle_OnConnect); //Bağlantı sağlandıktan sonra server kontrolleri.
  server.on("/led1on", handle_led1on);
  server.on("/led1off", handle_led1off);
  server.on("/led2on", handle_led2on);
  server.on("/led2off", handle_led2off);
  server.onNotFound(handle_NotFound);

  server.begin();
  Serial.println("HTTP Sunucusu Başladı");

}
void loop() {
  
  server.handleClient(); 
   if(LED1status)
  {digitalWrite(LED1pin, HIGH);}
  else
  {digitalWrite(LED1pin, LOW);}
  if(LED2status)
  {digitalWrite(LED2pin, HIGH);}
  else
  {digitalWrite(LED2pin, LOW);}
  
}

void handle_OnConnect() {

  Temperature = dht.readTemperature(); // 
  Humidity = dht.readHumidity(); // 
  LED1status = LOW;
  server.send(200, "text/html", SendHTML(Temperature,Humidity,LED1status,LED2status)); 
}
void handle_led1on() {
  LED1status = HIGH;
  Serial.println("D2 Durumu: ON");
  server.send(200, "text/html", SendHTML(Temperature,Humidity,true,LED2status)); 
}

void handle_led1off() {
  LED1status = LOW;
  Serial.println("D2 Durumu: OFF");
  server.send(200, "text/html", SendHTML(Temperature,Humidity,false,LED2status)); 
}

void handle_led2on() {
  LED2status = HIGH;
  Serial.println("D3 Durumu: ON");
  server.send(200, "text/html", SendHTML(Temperature,Humidity,LED1status,true)); 
}

void handle_led2off() {
  LED2status = LOW;
  Serial.println("D3 Durumu: OFF");
  server.send(200, "text/html", SendHTML(Temperature,Humidity,LED1status,false)); 
}

void handle_NotFound(){
  server.send(404, "text/plain", "Not found");
}

String SendHTML(float Temperaturestat,float Humiditystat,uint8_t led1stat,uint8_t led2stat){
  String ptr = "<!DOCTYPE html> <html>\n";
  ptr +="<head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, user-scalable=no\">\n";
  ptr +="<title>ESP8266 NodeMCU Akilli Ev</title>\n";
  ptr +="<style>html { font-family: Helvetica; display: inline-block; margin: 0px auto; text-align: center;}\n";
  ptr +="body{margin-top: 50px;} h1 {color: #444444;margin: 50px auto 30px;}\n";
  ptr +=".button {display: block;width: 80px;background-color: #1abc9c ;border: none;color: white;padding: 13px 30px;text-decoration: none;font-size: 25px;margin: 0px auto 35px;cursor: pointer;border-radius: 4px;}\n";
  ptr +=".button-on {background-color: #0095c7;}\n";
  ptr +=".button-on:active {background-color: #16a085;}\n";
  ptr +=".button-off {background-color: #34495e;}\n";
  ptr +=".button-off:active {background-color: #2c3e50;}\n";
  ptr +="p {font-size: 14px;color: #888;margin-bottom: 10px;}\n";
  ptr +="</style>\n";
  ptr +="</head>\n";
  ptr +="<body bgcolor= BlanchedAlmond style=color:white>\n";
  ptr +="<div id=\"webpage\">\n";
  ptr +="<h1>ESP8266 NodeMCU Akilli Ev</h1>\n";
  
  ptr +="<p>SICAKLIK: ";
  ptr +=(int)Temperaturestat;
  ptr +="°C</p>";
  ptr +="<p>NEM: ";
  ptr +=(int)Humiditystat;
  ptr +="%</p>";
  if(led1stat)
  {ptr +="<p>LED1 Durum: ACIK</p><a class=\"button button-off\" href=\"/led1off\">KAPAT</a>\n";}
  else
  {ptr +="<p>LED1 Durum: KAPALI</p><a class=\"button button-on\" href=\"/led1on\">AC</a>\n";}

  if(led2stat)
  {ptr +="<p>LED2 Durum: ACIK</p><a class=\"button button-off\" href=\"/led2off\">KAPAT</a>\n";}
  else
  {ptr +="<p>LED2 Durum: KAPALI</p><a class=\"button button-on\" href=\"/led2on\">AC</a>\n";}

   ptr +="<h1>DALKILIC SOFTWARE</h1>\n";

  
  return ptr;
}
