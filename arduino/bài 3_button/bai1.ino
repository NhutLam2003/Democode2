bool i = 0;
void setup() {
  // put your setup code here, to run once:
  pinMode(10,OUTPUT);
  pinMode(2,INPUT);
  pinMode(3,INPUT);
}

void loop() {
    // put your main code here, to run repeatedly:
  if(digitalRead(2)==1)
  {
    i = 1;
  }
  if(digitalRead(3)==1)
  {
    i = 0;
  }
    digitalWrite(10,i);
}
