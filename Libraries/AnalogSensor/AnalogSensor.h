#ifndef AnalogSensor_h
#define AnalogSensor_h

#include "Arduino.h"

class AnalogSensor{
	int _pin;
public:
	AnalogSensor(int pin_number);
	int read();
	int pin();
        void begin();
};

AnalogSensor::AnalogSensor(int pin_number){
	_pin = pin_number;
}
int AnalogSensor::read(){
	return analogRead(_pin);
}
int AnalogSensor::pin(){
	return _pin;
}

void AnalogSensor::begin(){
        pinMode(_pin, INPUT);
}
#endif
