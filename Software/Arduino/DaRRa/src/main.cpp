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

#include <Arduino.h> //Arduino library
#include <Wire.h>

#include "io_definitions.h"
#include "sensor.h"
#include "gear_motor.h"
#include "dc_motor.h"

#include "tasks/task_measureDistance.h"
#include "tasks/task_moveForward.h"
#include "tasks/task_moveBackward.h"
#include "tasks/task_turnLeft.h"
#include "tasks/task_turnRight.h"

#define MANUAL_MODUS 0
#define AUTOMATIC_MODUS 1

//state definitions
#define INIT_STATE 0
#define SETUP_STATE 1
#define DRIVE_FORWARD_STATE 2
#define DRIVE_BACKWARD_STATE 3
#define TURN_LEFT_STATE 4
#define TURN_RIGHT_STATE 5
#define HALT_STATE 8

int MIN_DIST_FRONT = 10;
int MIN_DIST_SIDE = 20;

int turn_time = 1200;

// current operation state of the robot
uint8_t state = 0;
int modus = MANUAL_MODUS;

//Sensor objects
Sensor B31_Distance_Right(1, B_TRIGGER, B31_ECHO);
Sensor B32_Distance_Left(2, B_TRIGGER, B32_ECHO);
Sensor B33_Distance_Front(3, B_TRIGGER, B33_ECHO);

//Gear motor objects
GearMotor M51_Left(GEAR_LEFT_FORWARD, GEAR_LEFT_BACKWARD, GEAR_LEFT_SPEED);
GearMotor M52_Right(GEAR_RIGHT_FORWARD, GEAR_RIGHT_BACKWARD, GEAR_RIGHT_SPEED);

//DC Motor
DCMotor M41_Pullout(MOTOR_PULLOUT);

// function prototypes
void manual_mod(char serial_key);
char read_serial_key();
void automatic_mod(char serial_key);

void setup()
{

  Serial.begin(115200);
}

void loop()
{

  // continous distance measurement
  task_measureDistance(&B31_Distance_Right, &B32_Distance_Left, &B33_Distance_Front);

  // read serial port
  char serial_key = read_serial_key();

  // set operation mode of the robot
  if (serial_key == '+')
  {
    modus = AUTOMATIC_MODUS;
  }
  else if (serial_key == 'Q')
  {
    modus = MANUAL_MODUS;
    M51_Left.stop();
    M52_Right.stop();
    M41_Pullout.stop();
    state = 0;
  }

  // call operation mode functions
  switch (modus)
  {
  case MANUAL_MODUS:
    manual_mod(serial_key);
    break;

  case AUTOMATIC_MODUS:
    automatic_mod(serial_key);
    break;
  }
}
/* end of void loop() */

char read_serial_key()
{

  if (Serial.available() > 0)
  {
    return Serial.read();
  }

  return -1;
}
/* end of read_serial_key() */

/**
 * @brief Manual operation mode
 * 
 * @param serial_key Operation key from com port
*/
void manual_mod(char serial_key)
{

  Serial.print("XP_1_");
  Serial.println(turn_time);
  Serial.print("XP_2_");
  Serial.println(MIN_DIST_FRONT);
  Serial.print("XP_3_");
  Serial.println(MIN_DIST_SIDE);
  delay(100);

  if (serial_key > 0)
  {

    switch (serial_key)
    {

    //Getriebemotor links vorwärts
    case 'A':
      M51_Left.setDirection(FORWARD);
      M51_Left.start();
      break;

    //Getriebemotor links rückwärts
    case 'B':
      M51_Left.setDirection(BACKWARD);
      M51_Left.start();
      break;

    //Getriebemotor links Stopp
    case 'C':
      M51_Left.stop();
      break;

    //Getriebemotor rechts vorwärts
    case 'D':
      M52_Right.setDirection(FORWARD);
      M52_Right.start();
      break;

    //Getriebemotor rechts rückwärts
    case 'E':
      M52_Right.setDirection(BACKWARD);
      M52_Right.start();
      break;

    //Getriebemotor rechts stopp
    case 'F':
      M52_Right.stop();
      break;

    //Getriebemotoren Synchronlauf vorwärts
    case 'G':
      task_moveForward(&M51_Left, &M52_Right);
      break;

    //Getriebemotoren Synchronlauf rückwärts
    case 'H':
      task_moveBackward(&M51_Left, &M52_Right);
      break;

    //Getriebemotoren stopp
    case 'I':
      M51_Left.stop();
      M52_Right.stop();
      break;

    //Auswurfrad starten
    case 'L':
      M41_Pullout.start();
      break;

    //Auswurfrad stoppen
    case 'S':
      M41_Pullout.stop();
      break;

    //Drehung um 180 Grad links
    case 'Y':
      task_turnLeft(&M51_Left, &M52_Right, turn_time);
      M51_Left.stop();
      M52_Right.stop();
      break;

    //Drehung um 180 Grad rechts
    case 'Z':
      task_turnRight(&M51_Left, &M52_Right, turn_time);
      M51_Left.stop();
      M52_Right.stop();
      break;

    case '_': //Kommando lesen

      String str;

      if (Serial.read() == 'V')
      {
        if (Serial.read() == '_')
        {
          char zahl = Serial.read();
          if (zahl == '1')
          {
            if (Serial.read() == '_')
            {
              str = Serial.readStringUntil('_');
              turn_time = str.toInt();
            }
          }
          else if (zahl == '2')
          {
            if (Serial.read() == '_')
            {
              str = Serial.readStringUntil('_');
              MIN_DIST_FRONT = str.toInt();
            }
          }
          else if (zahl == '3')
          {
            if (Serial.read() == '_')
            {
              str = Serial.readStringUntil('_');
              MIN_DIST_SIDE = str.toInt();
            }
          }
        }
      }
      break;

    } /* end of switch(c) */

  } /* end of if(Serial.available() > 0) */

} /* end of void manual_mode() */

/**
 * @brief Automatic operation mode
 * 
 * @param serial_key Operation key from com port
*/
void automatic_mod(char serial_key)
{

  Serial.write("XS_1_");
  Serial.println(state);
  delay(5);

  if (serial_key > 0)
  {

    //Schaltbedingung zu SETUP_STATE
    if (state == INIT_STATE && serial_key == 'J')
    {
      state = SETUP_STATE;
    }
  } //end of if(serial_key > 0)

  //Schaltbedingungen DRIVE_FORWARD_STATE
  if ((state == SETUP_STATE) || (state == TURN_RIGHT_STATE) || (state == DRIVE_BACKWARD_STATE) || (state == TURN_LEFT_STATE))
  {
    state = DRIVE_FORWARD_STATE;
  }

  //Schaltbedingungen DRIVE_BACKWARD_STATE
  if ((state == DRIVE_FORWARD_STATE) && (B33_Distance_Front.getDistance() < 15))
  {
    state = DRIVE_BACKWARD_STATE;
  }

  //Schaltbedingungen TURN_RIGHT_STATE
  if ((state == DRIVE_FORWARD_STATE) && (B31_Distance_Right.getDistance() > MIN_DIST_SIDE) && (B33_Distance_Front.getDistance() <= MIN_DIST_FRONT))
  {
    state = TURN_RIGHT_STATE;
  }

  //Schaltbedingungen TURN_LEFT_STATE
  else if ((state == DRIVE_FORWARD_STATE) && (B32_Distance_Left.getDistance() > MIN_DIST_SIDE) && (B33_Distance_Front.getDistance() <= MIN_DIST_FRONT))
  {
    state = TURN_LEFT_STATE;
  }

  switch (state)
  {

  case INIT_STATE:
    M51_Left.stop();
    M52_Right.stop();
    M41_Pullout.stop();
    break;

  case SETUP_STATE:
    M41_Pullout.start();
    break;

  case DRIVE_FORWARD_STATE:
    task_moveForward(&M51_Left, &M52_Right);
    break;

  case DRIVE_BACKWARD_STATE:
    task_moveBackward(&M51_Left, &M52_Right);
    break;

  case TURN_LEFT_STATE:
    task_turnLeft(&M51_Left, &M52_Right, turn_time);
    break;

  case TURN_RIGHT_STATE:
    task_turnRight(&M51_Left, &M52_Right, turn_time);
    break;

  } //end of switch(state)

} //end of void automatic_mod()