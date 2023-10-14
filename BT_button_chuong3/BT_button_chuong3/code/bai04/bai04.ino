unsigned long t_high1 = 100;
unsigned long t_high2 = 100000;
unsigned long t_high3 = 100000;
int t_cur = 0;
int t_high = 0;
void setup() {
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  pinMode(4, INPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
}

void loop() {
  bool sttBtn1 = digitalRead(2);
  bool sttBtn2 = digitalRead(4);
  bool sttBtn3 = digitalRead(6);
  t_cur = millis();
  if(sttBtn1 && t_high1 == 100){
    t_high1 = millis();
  }
  if(sttBtn2 && t_high2 == 100){
    t_high2 = millis();
  }
  if(sttBtn3 && t_high3 == 100){
    t_high3 = millis();
  }
  if(t_high1 < t_high2){
    if(t_high1 < t_high3){
      if(sttBtn1){
        digitalWrite(8, HIGH);
      }
      else{
        t_high = t_cur;
        t_high1 = 100;
        t_high2 = 100;
        t_high3 = 100;
      }
    }
  }
  if(t_high2 < t_high1){
    if(t_high2 < t_high3){
      if(sttBtn2){
        digitalWrite(10, HIGH);
      }
      else{
        t_high = t_cur;
        t_high1 = 100;
        t_high2 = 100;
        t_high3 = 100;
      }
    }
  }
  if(t_high3 < t_high1){
    if(t_high3 < t_high2){
      if(sttBtn3){
        digitalWrite(12, HIGH);
      }
      else{
        t_high = t_cur;
        t_high1 = 100;
        t_high2 = 100;
        t_high3 = 100;
      }
    }
  }
  if(t_high != 0){
    if(t_cur - t_high >= 300){
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(12, LOW);
    }
  }
}
