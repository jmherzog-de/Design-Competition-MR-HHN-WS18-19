/**
 * Design Competition MR HHN WS18/19
 * 
 * Copyright (c) Jean-Marcel Herzog
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software 
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

#include "Arduino.h"
#include "sensor.h"

/**
 * @brief Sensor Constructor for ultrasonic sensor
 * 
 * @param id identification number of the sensor
 * 
 * @param trigger_pin trigger measurement pin
 * 
 * @param echo_pin echo signal pin from ultrasonic sensor
*/
Sensor::Sensor(uint8_t id, uint8_t trigger_pin, uint8_t echo_pin)
{

  pinMode(trigger_pin, OUTPUT); // set trigger pin to output

  pinMode(echo_pin, INPUT); // set echo pin to input

  // save parameters local
  _trigger_pin = trigger_pin;
  _echo_pin = echo_pin;
  _sensor_ID = id;
}

/**
 * @brief Measure sequence
*/
void Sensor::measureDistance()
{

  long entfernung = -1;
  long zeit = 0;

  digitalWrite(_trigger_pin, LOW); // init trigger signal with 0
  delayMicroseconds(3);
  digitalWrite(_trigger_pin, HIGH); // trigger signal to 1 (measurement starts)
  delayMicroseconds(10);
  digitalWrite(_trigger_pin, LOW); // trigger signal to 0 (measurement finished)

  zeit = pulseIn(_echo_pin, HIGH); // measure time until echo come from sensor

  interrupts();

  zeit = (zeit / 2); // only single way to object needed

  entfernung = zeit / 29.1; // calculate distance

  if (entfernung == 0)
  {
    _distance = 2000;
  }
  else
  {
    _distance = entfernung; // save distance of the finished measurement
  }

  return;
} /* end of measureDistance() */

/**
 * @brief Get calculated distance
 * 
 * @return distance to object
*/
long Sensor::getDistance()
{
  return this->_distance;
}

/**
 * @brief Log distance over com port
*/
void Sensor::logDistance()
{

  Serial.print("XB_"); // keyword for desktop application
  Serial.print(_sensor_ID);
  Serial.print("_"); // signialize the end of a value
  Serial.print(_distance);
  Serial.println("_"); // signalize the end of a value
}
