void setup() {
  // put your setup code here, to run once:
  pinMode(10,OUTPUT);
  pinMode(2,INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(digitalRead(2)==1)
  {
    digitalWrite(10,1);
  }
  else
  {
    digitalWrite(10,0);
  }
}
