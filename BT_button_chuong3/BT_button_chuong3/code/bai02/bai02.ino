int led_value = 0;
int t_cur = 0;
int t_start = 0;
void setup() {
  pinMode(2, INPUT);
  pinMode(4, INPUT);
  pinMode(12, OUTPUT);
}

void loop() {
  bool sttBtn1 = digitalRead(2);
  bool sttBtn2 = digitalRead(4);
  t_cur = millis();
  if(t_cur - t_start >= 50){
    if(sttBtn1){
      led_value++;
      analogWrite(12, led_value);
    }
   if(sttBtn2){
      led_value--;
      analogWrite(12, led_value);
   }
   t_start = t_cur;
  }
}
