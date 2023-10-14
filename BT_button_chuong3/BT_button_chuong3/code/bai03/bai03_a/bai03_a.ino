void setup() {
  pinMode(2, INPUT);
  pinMode(12, OUTPUT);
}

void loop() {
  bool sttBtn = digitalRead(2);
  if(sttBtn){
    digitalWrite(12, HIGH);
  }
}
