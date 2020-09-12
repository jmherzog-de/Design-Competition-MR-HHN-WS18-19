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

#include <Arduino.h>
#include "dc_motor.h"

/**
 * @brief DC-Motor class
 * 
 * Implementation of the hardware-side control of a simple
 * DC-Motor.
 * 
 * @param MotorPin Arduino Pin for motor start/stop 
*/
DCMotor::DCMotor(uint8_t MotorPin)
{

    pinMode(MotorPin, OUTPUT);

    this->_MotorPin = MotorPin;
}
/* end of DCMOTOR(..) */

/**
 * @brief Start the DC-Motor
*/
void DCMotor::start()
{

    digitalWrite(_MotorPin, HIGH);
}
/* end of start() */

/**
 * @brief Stop the DC-Motor
*/
void DCMotor::stop()
{

    digitalWrite(_MotorPin, LOW);
}
/* end of stop() */