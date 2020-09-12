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
#include "gear_motor.h"

/**
 * @brief Gear Motor Constructor.
 * 
 * @param MotorPin_Forward Arduino GPIO Pin for motor forward
 * 
 * @param MotorPin_Backward Arduino GPIO Pin for motor backward
 * 
 * @param MotorPin_Speed Arduino GPIO Pin to control motor speed
*/
GearMotor::GearMotor(uint8_t MotorPin_Forward, uint8_t MotorPin_Backward, uint8_t MotorPin_Speed)
{

    //Informationen in lokale Variablen speichern
    this->_MotorPin_Forward = MotorPin_Forward;
    this->_MotorPin_Backward = MotorPin_Backward;
    this->_MotorPin_Speed = MotorPin_Speed;

    pinMode(MotorPin_Forward, OUTPUT); //MotorPin_Forward als Ausgang festlegen

    pinMode(MotorPin_Backward, OUTPUT); //MotorPin_Backward als Eingang festlegen
}

/**
 * @brief Gear Motor start
*/
void GearMotor::start()
{

    analogWrite(_MotorPin_Speed, _speed); //PWM Geschwindigkeit

    if (_direction == 1)
    { //Vorwärtsbewegung
        digitalWrite(_MotorPin_Backward, LOW);
        digitalWrite(_MotorPin_Forward, HIGH);
    }
    else
    { //Rückwärtsbewegung
        digitalWrite(_MotorPin_Forward, LOW);
        digitalWrite(_MotorPin_Backward, HIGH);
    }
}

/**
 * @brief Gear Motor stop
*/
void GearMotor::stop()
{

    digitalWrite(_MotorPin_Backward, LOW);
    digitalWrite(_MotorPin_Forward, LOW);
}

/**
 * @brief Gear Motor set motor speed
 * 
 * @param percent Percentage of available Gear Motor speed.
*/
void GearMotor::setSpeed(uint8_t percent)
{
    if (percent >= 0 && percent <= 100)
    {
        _speed = (255 / 100) * percent; //Normierung der Geschwindigkeit von 0-255
    }
    else
    {
        Serial.println("Error: Incorrect motor speed level given.");
    }
}

void GearMotor::setDirection(uint8_t dir)
{
    _direction = dir;
}
