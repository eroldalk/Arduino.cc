#define yesil 7
#define kirmizi 8
#define pirsensorumuz 3
int hareket;

void setup()
{
pinMode(pirsensorumuz, INPUT);
pinMode(yesil, OUTPUT);
pinMode(kirmizi, OUTPUT);
}
 

void loop()
{
hareket=digitalRead(pirsensorumuz); // pir sensöründen verileri oku vehareket isimli değişkene aktar

if (hareket == 1) // hareket algılandıysa
  {
  digitalWrite(kirmizi, 1);
  digitalWrite(yesil,0);
  }
else
  {
  digitalWrite(yesil, 1);
  digitalWrite(kirmizi, 0);
  }


}
