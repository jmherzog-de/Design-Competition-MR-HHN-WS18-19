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

#ifndef _GEAR_MOTOR_H
#define _GEAR_MOTOR_H

#include <inttypes.h>

#define FORWARD 1
#define BACKWARD 0

class GearMotor
{

public:
    GearMotor(uint8_t MotorPin_Forward, uint8_t MotorPin_Backward, uint8_t MotorPin_Speed);
    void start();
    void setSpeed(uint8_t speed);
    void setDirection(uint8_t dir);
    void stop();

private:
    uint8_t _MotorPin_Forward;
    uint8_t _MotorPin_Backward;
    uint8_t _MotorPin_Speed;
    uint8_t _speed = 150;
    uint8_t _direction = 1; //1=forward 0=backward
};

#endif