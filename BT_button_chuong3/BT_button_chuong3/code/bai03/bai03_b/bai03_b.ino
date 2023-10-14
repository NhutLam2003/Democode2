int t_high = 0;
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
    if(t_cur - t_high >= 3000){
      digitalWrite(12, HIGH);
      t_high = t_cur;
    }
  }
  else{
    t_high = t_cur;
  }
}
