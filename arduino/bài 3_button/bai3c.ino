int btn = 2;
int led = 10;
unsigned long t_high1 = 0;
unsigned long t_high2 = 0;
unsigned long t_low = 0;
unsigned long t_cur = 0;
int btnStt = 0;
void setup() {
  // put your setup code here, to run once:
  pinMode(btn, INPUT);
  pinMode(led, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  btnStt = digitalRead(btn);
  t_cur = millis();
  if(btnStt == HIGH)
  {
    if(t_high1 == 0)
    {
      t_high1 = t_cur;
    }
    if(t_high2 == 0 && t_low != 0)
    {
      t_high2 = t_cur;
    }
  }
  else
  {
    if(t_high2 != 0 && t_cur - t_high1 < 1000)
    {
      digitalWrite(led,1);
      t_high1 = 0;
      t_low = 0;
      t_high2 = 0;
    }
    if(t_high1 != 0 && t_cur - t_high1 >= 1000)
    {
      t_high1 = 0;
      t_low = 0;
      t_high2 = 0;
    }
    else
    {
      if(t_high1 != 0 && t_low == 0)
      {
        t_low = t_cur;
      }
    }
  }
}
