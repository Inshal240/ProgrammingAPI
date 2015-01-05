#ifndef Flow_h
#define Flow_h

#if defined(ARDUINO) && (ARDUINO >= 100)
#include <Arduino.h>
#else
#include <WProgram.h>
#endif

extern int pulses1 = 0;
extern int pulses2 = 0;

extern int currentTime = 0;
extern int avg_read_time = 0; 

void rpm1();
void rpm2();

class Flow{
  int pin;
  float Calc, litres,sum, avg;
  int count;
  

public:

  Flow(int pin_no);
  void calculate();
  void begin();
  void update();
  float get_litres();

};

void  rpm1(){
    pulses1++;
  }
  
void rpm2(){
    pulses2++;
  }
  
Flow::Flow(int pin_no){
  Calc = litres = sum = avg = 0;
  count = 0;
  
  pin = pin_no;

}  
  
void Flow::calculate(){
    avg = sum/count;
    litres = avg * 60;
    sum = 0;
    count = 0;
}


float Flow::get_litres(){
  return litres;
}
  

  
void Flow::update()
{
  int pulses, interrupt;
  void (*rpm)();
  if (pin == 2){
    pulses = pulses1;
    interrupt = 0;
    rpm = rpm1;
  }
  else{
    pulses = pulses2;
    interrupt = 1;
    rpm = rpm2;
  }  
  cli();
  pulses = 0;
  attachInterrupt(interrupt, rpm, RISING);
  sei();            //Enables interrupts
  delay (1000);
  cli();      //Disable interrupts
  detachInterrupt(interrupt);
  count++;
  Calc = (pulses / 7.5); // (Pulse frequency ) / 7.5 = flow rate in L/minute
  sum += Calc;
  sei();
}

void Flow::begin(){

  pinMode(pin, INPUT);
  if( pin == 2)
    attachInterrupt(0, rpm1, RISING);
  else if(pin == 3)
    attachInterrupt(1, rpm2, RISING);
}


#endif
