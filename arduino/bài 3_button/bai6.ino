#define xanh 10
#define doo 9
#define vang 8
#define button 2
#define xanhsang(); digitalWrite(xanh,1);
#define doosang(); digitalWrite(doo,1);
#define vangsang(); digitalWrite(vang,1);
#define xanhtat(); digitalWrite(xanh,0);
#define dootat(); digitalWrite(doo,0);
#define vangtat(); digitalWrite(vang,0);

int luachon=0,an;

void setup() {
  pinMode(xanh,OUTPUT);
  pinMode(doo,OUTPUT);
  pinMode(vang,OUTPUT);
  pinMode(button,INPUT);
 

}

void loop() {
  buttons();
  chonled();

}

void buttons()
{
  
  if(digitalRead(button)==1)
  {
   
    an=an-1;
    if(an==5)
    {
      luachon++;
      if(luachon>=6)
      {
        luachon=1;
      }
    }
    if(an==0)
    {
      an=1;
    }
  }
else
an=20;
  
}

void chonled()
{
  switch (luachon)
  {
    case 1:
    {
      vangsang();
      dootat();
      xanhtat();
      break;
    }
    case 2:
    {
      doosang();
      vangtat();
      xanhtat();
      break;
    }
    case 3:
    {
      xanhsang();
      vangtat();
      dootat();
      break;
    }
    case 4:
    {
      xanhsang();
      vangsang();
      doosang();
      break;
    }
    case 5:
    {
      xanhtat();
      vangtat();
      dootat();
      break;
    }
  }
}