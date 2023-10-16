int btn_up = 2;
int btn_down = 3;
int led = 9;
int btnStatus_up = 0;
int btnStatus_down = 0;
bool isBtnPress_up = false;
bool isBtnPress_down = false;

int brightness = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(btn_up, INPUT);
  pinMode(btn_down, INPUT);
  pinMode(led, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  btnStatus_up = digitalRead(btn_up);
  btnStatus_down = digitalRead(btn_down);
  //Btn Up
  if(btnStatus_up == HIGH)
  {
    isBtnPress_up = true;
  }
  else
  {
    if(brightness < 100 && isBtnPress_up)
    {
      brightness += 25;
      isBtnPress_up = !isBtnPress_up;
    }
  }
//Btn Down
  if(btnStatus_down == HIGH)
  {
    isBtnPress_down = true;
  }
  else
  {
    if(brightness > 0 && isBtnPress_down)
    {
      brightness -= 25;
      isBtnPress_down = !isBtnPress_down;
    }
  }
  byte pwmvalue = 255;
  pwmvalue = (brightness * 255 / 100);
  analogWrite(led, pwmvalue);
}
