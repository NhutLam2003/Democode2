#include <Wire.h>
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 16,2);
 
void setup() {
lcd.init();
lcd.backlight();
//lcd.setCursor(0, 1);
//lcd.print("Arduino!");
}
 
void loop() {
// lcd.setCursor(0, 0);
// lcd.print("Hello");
// for(int i = 0; i<11;i++)
// {
//   lcd.scrollDisplayRight();
//   delay(200);
// }
// for(int i = 0; i<11;i++)
// {
//   lcd.scrollDisplayLeft();
//   delay(200);
// }
byte chuD[8]={
  B00000,
  B00000,
  B00000,
  B11110,
  B10001,
  B10001,
  B10001,
  B11110,
};

byte chuU[8]={
  B00000,
  B00000,
  B00000,

  B10001,
  B10001,
  B10001,
  B10001,
  B11111,
};

byte chuY[8]={
  B00000,
  B00000,
  B00000,

  B10001,
  B01010,
  B00100,
  B00100,
  B00100,
};
byte chuE[8]={
  B01110,
  B10001,
  B00000,

  B11111,
  B10000,
  B11111,
  B10000,
  B11111,
};
byte chuN[8]={
  B00000,
  B00000,
  B00000,

  B10001,
  B11001,
  B10101,
  B10011,
  B10001,
};
lcd.createChar(0,chuD);
lcd.setCursor(0, 0);
lcd.write(byte(0));
lcd.createChar(1,chuU);
lcd.setCursor(1, 0);
lcd.write(byte(1));
lcd.createChar(2,chuY);
lcd.setCursor(2, 0);
lcd.write(byte(2));
lcd.createChar(3,chuE);
lcd.setCursor(3, 0);
lcd.write(byte(3));
lcd.createChar(4,chuN);
lcd.setCursor(4, 0);
lcd.write(byte(4));
}