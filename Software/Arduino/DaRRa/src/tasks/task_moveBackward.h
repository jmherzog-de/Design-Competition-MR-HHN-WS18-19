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

#ifndef _TASK_MOVEBACKWARD_H
#define _TASK_MOVEBACKWARD_H

#define BACKWARD 0
#define FORWARD 1

#include <Arduino.h>
#include "../gear_motor.h"

/**
 * @brief Robot drive backward.
 * 
 * Change direction of robot to backward.
 * 
 * @param Motor_Left Gear Motor object of left motor
 * 
 * @param Motor_Right Gear Motor object of right motor
*/
void task_moveBackward(GearMotor *Motor_Left, GearMotor *Motor_Right)
{

    Motor_Left->setDirection(BACKWARD);
    Motor_Right->setDirection(BACKWARD);

    Motor_Left->start();
    Motor_Right->start();
}
/* end of task_moveBackward(...) */

#endif
