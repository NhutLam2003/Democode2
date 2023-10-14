int t_high = 0;
int t_high2 = 0;
int t_low = 0;
int t_cur = 0;
void setup() {
  // put your setup code here, to run once:
  pinMode(2, INPUT);
  pinMode(12, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  bool sttBtn = digitalRead(2);
  t_cur = millis();
  if(sttBtn){
    if(t_high == 0){
      t_high = t_cur;
    }
    else{
      if(t_low != 0 && t_high2 == 0)
        t_high2 = t_cur;
    }
  }
  else{
     if(t_high2 != 0 && t_cur - t_high <= 1000){
        digitalWrite(12, HIGH);
        t_high = 0;
        t_high2 = 0;
        t_low = 0;
      }
      else{
        if(t_cur - t_high > 1000){
          t_high = 0;
          t_high2 = 0;
          t_low = 0;
        }
       }
      if(t_high != 0)
        t_low = t_cur;
  }
}
