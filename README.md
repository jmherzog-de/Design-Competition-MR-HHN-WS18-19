# Design competition - Mechatronic and robotic HHN WS18/19

This is the repository for the Design competition at the University of Applied Science Heilbronn on the WS 18/19.

# Exercise description

Some description of the exercise.

# Design concept

# Hardware

<p style="text-align: justify;">
The hardware used by the DaRRa robot has been optimized for the lowes possible power consumption due to severely limited energy guidelines (only 4 AA batteries permitted). A graphical overview of the power supply can be found in the section Power Supply.<br>
During construction, the focus was on realizing the required functionalities with as gew operating resources as possible. At the same time, however, the maximum flexibility shoubld be made possible in order to solbe these complex task.<br>
The following table provides an inital overview of all electrical equipment used in the project. Stating their equipment identification, so that they are easier to identify in the circuit diagram. There are also a complete circuit diagram in this repository.
</p>

|                                                  |      BMK       | Description                                                                                                                                                                                                                                                                          |
| :----------------------------------------------: | :------------: | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
|          ![Arduino](images/Arduino.png)          |      -F11      | The Arduino Uno is the heart of the DaRRa robot. <br>The Arduino provides flexible, simple and fast control of all actuators and sensors.                                                                                                                                            |
|          ![HC-SR04](images/HCSR04.png)           | -B31 -B32 -B33 | Distances at front and on the sides where measured by the ultrasonic sensors.                                                                                                                                                                                                        |
|           ![TIP120](images/TIP120.png)           |      -Q41      | The Darlington transistor controls the DC motor for the Throwout-wheel.                                                                                                                                                                                                              |
|            ![LN298](images/L298.png)             |      -A51      | This board was purchased as a ready to use component. The board has an L298-H-bridge with wich the motors of the main drive are controlled. This enables both a reversal of the direction and a speed adjustment.                                                                    |
|            ![Motor](images/Motor.png)            |      -M41      | The brushed DC motor where used to control the throwout wheel. A Darlington transistor (-Q41) starts or stops the motor.                                                                                                                                                             |
|       ![Gear-Motor](images/Gear-Motor.png)       |   -M51 -M 52   | These are normal brushed DC motors, coupled with a reduction gear. This reduces the speed, but increases the torque.                                                                                                                                                                 |
|     ![Power-Supply](images/Power-Supply.png)     |     - U11      | As specified in the guidlines, 4 AA batteries were used for the energy supply. These batteries were placed in a housing with an on/off switch. In this way, the entire robot can easily be switched off. The batteries are connected in series, resulting in a total voltage of 6 V. |
| ![Bluetooth-Module](images/Bluetooth-Module.png) |      -A12      | The Bluetooth module is connected to the Arduino via the serial interface. The module is used to communicate with the DaRRa Interface. The module is powered with 3.3 V from the Arduino Pin.                                                                                        |

# Power supply

<p style="text-align: justify;">
The entire energy supply is ensured by four AA batteries connected in series. The four 1.5 V AA batteries connected in series provides a total voltage of 6 V. However, this level drops significantly during operation. The battery voltage was connectoed to luster terminals and distributed to the individual electrical components.
</p>
<p align="center">
  <img width="100%" height="100%" src="images/Energy-Diagram.png">
</p>

|                                    |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| <img src="images/Vcc-Circuit.png"> | The ultrasonic sensors and the bluetooth module are supplied by the Arduino's internal voltage converter. The internal power supply on the Arduino board can be seen in the following picture. With the amplifier U5A and the voltage divider in front of it, each with 10 kΩ resistors. They make it possible to connect higher voltage (see technical data sheet of the Arduino board) at the Arduino. For this reason the battery voltage is applied to the Vin pin. The voltage for the ultrasonic sensors is connected at the +5 V pin. The power supply for the bluetooth modul takes place at the +3.3 V pin.<br> |

# The Arduino Uno R3

![Arduino-Detail](images/Arduino-Detail.png)

Some facts about the Arduino.

# LN298 Motor driver

Some facts about the used motor driver board

![L298-detail](images/L298-detail.png)

# Software

Explenation of the software.

![Software-Detail](images/Software-Detail.png)

# State Machine

![State-Machine](images/State-machine.png)

## Realtime control and monitoring

Explenation of the desktop application to monitor data an control the robot over bluetooth.

![DaRRa-Interface](images/DaRRa-Interface.png)
![DaRRa-Interface-2](images/DaRRa-Interface-2.png)
![DaRRa-Interface-3](images/DaRRa-Interface-3.png)
