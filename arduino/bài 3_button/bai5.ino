int btn1 = 2;
int btn2 = 3;
int btn3 = 4;
bool btn1PressedEarly = false;
bool btn2PressedEarly = false;
bool btn3PressedEarly = false;

int ledw = 10;
int ledr = 9;
int ledg = 8;
void setup() {
  // put your setup code here, to run once:
  pinMode(ledw, OUTPUT);
  pinMode(ledr, OUTPUT);
  pinMode(ledg, OUTPUT);
  pinMode(btn1, INPUT);
  pinMode(btn2, INPUT);
  pinMode(btn3, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:

  if(digitalRead(btn1) == HIGH)
  {
    if(digitalRead(btn2) == LOW && digitalRead(btn3) == LOW)
    {
      btn1PressedEarly = true;
    }
  }
  else
  {
    btn1PressedEarly = false;
  }
  if(digitalRead(btn2) == HIGH)
  {
    if(digitalRead(btn1) == LOW && digitalRead(btn3) == LOW)
    {
      btn2PressedEarly = true;
    }
  }
  else
  {
    btn2PressedEarly = false;
  }
  if(digitalRead(btn3) == HIGH)
  {
    if(digitalRead(btn1) == LOW && digitalRead(btn2) == LOW)
    {
      btn3PressedEarly = true;
    }
  }
  else
  {
    btn3PressedEarly = false;
  }
  if(digitalRead(btn1) == HIGH && digitalRead(btn2) == HIGH && digitalRead(btn3) == HIGH)
  {
    if(btn1PressedEarly && !btn2PressedEarly && !btn3PressedEarly)
    {
      digitalWrite(ledw, 1); delay(3000);
      digitalWrite(ledr, 0);
      digitalWrite(ledg, 0);
      if(digitalRead(btn2) == LOW || digitalRead(btn3) == LOW)
      {
        digitalWrite(ledw, 0);
        digitalWrite(ledr, 0);
        digitalWrite(ledg, 0);
      }
      else
      {
        delay(3000);
        digitalWrite(ledw, 0);
      }
    }
    if(!btn1PressedEarly && btn2PressedEarly && !btn3PressedEarly)
    {
      digitalWrite(ledw, 0);
      digitalWrite(ledr, 1);
      digitalWrite(ledg, 0);
      if(digitalRead(btn3) == LOW || digitalRead(btn1) == LOW)
      {
        digitalWrite(ledw, 0);
        digitalWrite(ledr, 0);
        digitalWrite(ledg, 0);
      }
      else
      {
        delay(3000);
        digitalWrite(ledr, 0); 
      }
    }
    if(!btn1PressedEarly && !btn2PressedEarly && btn3PressedEarly)
    {
      digitalWrite(ledw, 0);
      digitalWrite(ledr, 0);
      digitalWrite(ledg, 1);
      if(digitalRead(btn2) == LOW || digitalRead(btn1) == LOW)
      {
        digitalWrite(ledw, 0);
        digitalWrite(ledr, 0);
        digitalWrite(ledg, 0);
      }
      else
      {
        delay(3000);
        digitalWrite(ledg, 0);
      }
    }
  } 
  if(digitalRead(btn1) == LOW && digitalRead(btn2) == LOW && digitalRead(btn3) == LOW)
  {
    digitalWrite(ledw, 0);
    digitalWrite(ledr, 0);
    digitalWrite(ledg, 0);
    btn1PressedEarly = false;
    btn2PressedEarly = false;
    btn3PressedEarly = false;
  }
}