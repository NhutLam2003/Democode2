#include <Wire.h>
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 16,2);
int but1 = 2;
int but2 = 3;
int but3 = 4;
int but4 = 5;
int tt= 0;
int tt1= 0;
int tt2= 0;
int tt3= 0;
int i =0;
byte chuA[8]={
  B00000,
  B00000,
  B00000,
  B01110,
  B10001,
  B11111,
  B10001,
  B10001,
};
byte chuB[8]={
  B00000,
  B00000,
  B00000,
  B11110,
  B10001,
  B11110,
  B10001,
  B11110,
};
byte chuC[8]={
  B00000,
  B00000,
  B00000,
  B11111,
  B10000,
  B10000,
  B10000,
  B11111,
};
byte chuS[8]={
  B00000,
  B00000,
  B00000,
  B11111,
  B10000,
  B11111,
  B00001,
  B11111,
};
byte chuAA[8]={
  B00100,
  B01010,
  B00000,
  B01110,
  B10001,
  B11111,
  B10001,
  B10001,
};
byte chuAS[8]={
  B00010,
  B00100,
  B01000,
  B00000,
  B10001,
  B11111,
  B10001,
  B10001,
};

void setup() {
  // put your setup code here, to run once:
  lcd.init();
  lcd.backlight();
  pinMode(but1,INPUT);
  pinMode(but2,INPUT);
  pinMode(but3,INPUT);
  pinMode(but4,INPUT);
  lcd.createChar(0,chuA);
  lcd.createChar(1,chuB);
  lcd.createChar(2,chuC);
  lcd.createChar(3,chuS);
  lcd.createChar(4,chuAA);
  lcd.createChar(5,chuAS);
} 

void loop() {
  // put your main code here, to run repeatedly:
  
  if(digitalRead(but1)==1)
    {
      tt=!tt;
    }
    else
    {
      if(tt)
      {
        i++;
        lcd.setCursor(i, 0);
        lcd.write(0);
        tt = 0;
      }
    }
    if(digitalRead(but2)==1)
    {
      tt1=!tt1;
    }
    else
    {
      if(tt1)
      {
        i++;
        lcd.setCursor(i, 0);
        lcd.write(1);
        tt1 = 0;
      }
    }
    if(digitalRead(but3)==1)
    {
      tt2=!tt2;
    }
    else
    {
      if(tt2)
      {
        i++;
        lcd.setCursor(i, 0);
        lcd.write(2);
        tt2 = 0;
      }
    }
    if(digitalRead(but4)==1)
    {
      tt3=!tt3;
    }
    else
    {
      if(tt3)
      {
        i++;
        lcd.setCursor(i, 0);
        lcd.write(3);
        tt3 = 0;
      }
    }
}


