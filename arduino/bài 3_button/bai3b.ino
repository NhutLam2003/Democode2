int btn = 2;
int led = 10;
unsigned long t_pres = 0;
unsigned long t_cur = 0;
void setup() {
  pinMode(btn, INPUT);
  pinMode(led, OUTPUT);
}
void loop() {
  t_cur = millis();
  if(digitalRead(btn) == 1)
  {
    if(t_pres == 0)
    {
      t_pres = t_cur;
    }
  }
  else
  {
    if(t_cur - t_pres >= 3000 && t_pres != 0)
    {
      digitalWrite(led, 1);
      t_pres = 0;
    }
    else
    {
      t_pres = 0;
    }
  }
}
