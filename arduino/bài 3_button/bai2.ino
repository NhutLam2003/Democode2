bool tt = false;
bool u = false;

int i = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  pinMode(10, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  //Btn Up
  if (digitalRead(2) == 1) {
    tt = true;
  } else {
    if (i < 100 && tt) {
      i += 25;
      tt = !tt;
    }
  }
  //Btn Down
  if (digitalRead(3)) {
    u = true;
  } else {
    if (i > 0 && u) {
      i -= 25;
      u = !u;
    }
  }
  byte pwmvalue = 255;
  pwmvalue = (i * 255 / 100);
  analogWrite(10, pwmvalue);
}
