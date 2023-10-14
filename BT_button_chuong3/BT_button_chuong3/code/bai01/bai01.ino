void setup() {
  // put your setup code here, to run once:
  pinMode(2, INPUT);
  pinMode(4, INPUT);
  pinMode(12, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  bool sttBtn1 = digitalRead(2);
  bool sttBtn2 = digitalRead(4);
  if(sttBtn1){
    digitalWrite(12, HIGH);
  }
  if(sttBtn2){
    digitalWrite(12, LOW);
  }
}
