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

#ifndef _TASK_MEASUREDISTANCE_H
#define _TASK_MEASUREDISTANCE_H
#include <Arduino.h>
#include "../sensor.h"

/**
 * @brief Distance measurement task.
 * 
 * Distance measurement at front and both sides of the robot.
 * 
 * @param S1 Measurement data pointer of sensor 1
 * 
 * @param S2 Measurement data pointer of sensor 2
 * 
 * @param S3 Measurement data pointer of sensor 3
*/
void task_measureDistance(Sensor *S1, Sensor *S2, Sensor *S3)
{

    S1->measureDistance();
    delay(2);
    S2->measureDistance();
    delay(2);
    S3->measureDistance();

    S1->logDistance();
    delay(10);
    S2->logDistance();
    delay(10);
    S3->logDistance();
    delay(10);
}
/* end of task_measurementDistance(...) */

#endif