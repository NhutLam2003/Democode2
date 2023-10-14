int dem = 0;
bool sttBtn = 0;
bool sttBtnLast = 0;
void setup() {
  pinMode(8, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(2, INPUT);
}

void loop() {
  sttBtn = digitalRead(2);
  if(sttBtn){
    if(sttBtn != sttBtnLast){
      dem++;
    }
  }
  sttBtnLast = sttBtn;
  switch(dem){
    case 1:
      digitalWrite(8, HIGH);
      digitalWrite(10, LOW);
      digitalWrite(12, LOW);
      break;
    case 2:
      digitalWrite(8, LOW);
      digitalWrite(10, HIGH);
      digitalWrite(12, LOW);
      break;
    case 3:
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(12, HIGH);
      break;
    case 4:
      digitalWrite(8, HIGH);
      digitalWrite(10, HIGH);
      digitalWrite(12, HIGH);
      break;
    case 5:
      digitalWrite(8, LOW);
      digitalWrite(10, LOW);
      digitalWrite(12, LOW);
      break;
    case 6:
      dem = 1;
      break;
  }
}
