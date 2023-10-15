#include <LiquidCrystal.h>
LiquidCrystal lcd(12, 11, 5, 4, 3,2);
void setup() {
lcd.begin(16, 2);
lcd.setCursor(0, 0);
lcd.print("HELLO");
}
void loop() {

// lcd.display();
// delay(500);
// lcd.noDisplay();
// delay(500);
//Cau b
// char worf[]="HELLO";
// for(int i=0;i<strlen(worf);i++)
// {
//   lcd.print(worf[i]);
//   delay(500);
//   if(i==strlen(worf))
//   {
//     lcd.clear();
//   }
// }
// while(true){}


// lcd.setCursor(11, 0);
// lcd.print("HELLO");
// lcd.scrollDisplayLeft();
// delay(500);


// lcd.scrollDisplayRight();
// delay(500);

}









/* #include <LiquidCrystal.h>
 LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
 void setup() {
   lcd.begin(16, 2);
   lcd.print("HELLO");
   delay(100);
 }
 void loop() {
  //  lcd.scrollDisplayRight();
  //  delay(100);
  
    for (int positionCounter = 0; positionCounter < 16; positionCounter++) {
   
      lcd.scrollDisplayRight();
      delay(100);
    }
    for (int positionCounter = 16; positionCounter < 0; positionCounter--) {
   
      lcd.scrollDisplayLeft();
      delay(100);
    }
  

  for (int positionCounter = 0; positionCounter < 29; positionCounter++) {
    lcd.scrollDisplayRight();
    delay(150);
  }
 
  for (int positionCounter = 0; positionCounter < 16; positionCounter++) {
    lcd.scrollDisplayLeft();
    delay(150);
  } 
  


 }
*/


// #include <LiquidCrystal.h>
// LiquidCrystal lcd(12, 11, 5, 4, 3, 2); 
// unsigned long t_pre=0;
// bool check = false;
// void setup() {
//  lcd.begin(16, 2); 
//  lcd.setCursor(0, 1); 
//  lcd.print("Arduino!"); 
//  lcd.setCursor(0, 0); 
//  lcd.print("Hello"); 
// }
 
// void loop() {
 
//  if(millis()-t_pre>=500)
//  {
//     check = !check;
//     t_pre = millis();
//  }
//  if(check){
//   // lcd.setCursor(0,0);
//   // lcd.print("Hello");
//   lcd.noDisplay();
//  }
//  else{
//   lcd.display();
//  }
// } 