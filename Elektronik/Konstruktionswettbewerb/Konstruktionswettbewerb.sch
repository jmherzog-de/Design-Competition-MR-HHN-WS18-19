EESchema Schematic File Version 4
LIBS:Konstruktionswettbewerb-cache
EELAYER 26 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 5
Title "Konstruktionswettbewerb"
Date ""
Rev "3"
Comp "DaRRa"
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Sheet
S 650  850  550  550 
U 5BF07C80
F0 "PWR" 50
F1 "PWR.sch" 50
F2 "GND" I R 1200 1200 50 
F3 "+6V" O R 1200 1000 50 
$EndSheet
$Sheet
S 8100 2650 2050 1250
U 5BF07DBC
F0 "Ultrasonic" 50
F1 "Ultrasonic.sch" 50
F2 "+5V" I L 8100 2850 50 
F3 "GND" I L 8100 3050 50 
F4 "Trig_Distance" I L 8100 3250 50 
F5 "Echo_B31" O R 10150 3000 50 
F6 "Echo_B32" O R 10150 3300 50 
F7 "Echo_B33" O R 10150 3600 50 
$EndSheet
$Comp
L Konstruktionswettbewerb-rescue:Arduino_Uno_R3-MCU_Microchip_AVR -K11
U 1 1 5BF09C64
P 2750 2600
F 0 "-K11" H 2750 3115 50  0000 C CNN
F 1 "Arduino_Uno_R3" H 2750 3024 50  0000 C CNN
F 2 "" H 2700 3050 50  0001 C CNN
F 3 "" H 2700 3050 50  0001 C CNN
	1    2750 2600
	1    0    0    -1  
$EndComp
Text Notes 8650 3800 0    50   ~ 0
Ultrasonic Distance Sensors
Text Notes 1200 1350 2    50   ~ 0
Power Supply
Text GLabel 10500 3000 2    50   Input ~ 0
-K11:7
Text GLabel 10500 3300 2    50   Input ~ 0
-K11:8
Text GLabel 10500 3600 2    50   Input ~ 0
-K11:9
Wire Wire Line
	10500 3000 10150 3000
Wire Wire Line
	10500 3300 10150 3300
Wire Wire Line
	10500 3600 10150 3600
Text GLabel 4500 3300 2    50   Output ~ 0
Echo_B31
Text GLabel 4500 3100 2    50   Output ~ 0
Echo_B32
Text GLabel 4500 2900 2    50   Output ~ 0
Echo_B33
Text GLabel 3650 3600 2    50   Input ~ 0
Trig_Distance
Wire Wire Line
	3450 3600 3650 3600
Text GLabel 8000 3450 3    50   Output ~ 0
-K11:5
Wire Wire Line
	8000 3450 8000 3250
Wire Wire Line
	8000 3250 8100 3250
$Sheet
S 9100 4450 1050 900 
U 5BF1A2A2
F0 "DC-Motor" 50
F1 "DC-Motor.sch" 50
F2 "GND" O L 9100 4850 50 
F3 "+6V" I L 9100 4650 50 
F4 "Motor_Start" I R 10150 5050 50 
$EndSheet
Text GLabel 4300 2600 2    50   Input ~ 0
PWM_Gear_Motor_Left_Backward
Text GLabel 4300 2400 2    50   Input ~ 0
PWM_Gear_Motor_Right_Backward
Text GLabel 4300 2200 2    50   Input ~ 0
PWM_Gear_Motor_Right_Forward
Text GLabel 4300 2000 2    50   Input ~ 0
PWM_Gear_Motor_Left_Forward
Wire Wire Line
	3450 3400 4350 3400
Wire Wire Line
	4350 3400 4350 3300
Wire Wire Line
	4350 3300 4500 3300
Wire Wire Line
	4500 3100 4300 3100
Wire Wire Line
	4300 3100 4300 3150
Wire Wire Line
	4300 3150 3400 3150
Wire Wire Line
	4500 2900 4200 2900
Wire Wire Line
	4200 2900 4200 3050
Wire Wire Line
	4200 3050 3400 3050
Wire Wire Line
	4300 2600 4000 2600
Wire Wire Line
	4000 2600 4000 2950
Wire Wire Line
	4000 2950 3400 2950
Wire Wire Line
	4300 2400 3850 2400
Wire Wire Line
	3850 2400 3850 2850
Wire Wire Line
	3850 2850 3400 2850
Wire Wire Line
	4300 2200 3700 2200
Wire Wire Line
	3700 2200 3700 2750
Wire Wire Line
	3700 2750 3400 2750
Wire Wire Line
	4300 2000 3550 2000
Wire Wire Line
	3550 2000 3550 2650
Wire Wire Line
	3550 2650 3400 2650
Text Notes 9750 1600 2    50   ~ 0
Gear-Motor Main-drive
$Sheet
S 8500 700  1650 950 
U 5BF1A29E
F0 "Gear-Motor" 50
F1 "Gear-Motor.sch" 50
F2 "GND" O L 8500 1200 50 
F3 "+6V" I L 8500 1000 50 
F4 "PWM_Gear_Motor_Left_Forward" I R 10150 850 50 
F5 "PWM_Gear_Motor_Right_Forward" I R 10150 1000 50 
F6 "PWM_Gear_Motor_Right_Backward" I R 10150 1200 50 
F7 "PWM_Gear_Motor_Left_Backward" I R 10150 1350 50 
$EndSheet
Wire Wire Line
	1200 1200 1650 1200
Wire Wire Line
	8100 3050 7250 3050
Wire Wire Line
	1200 1000 1500 1000
Wire Wire Line
	2050 3050 1650 3050
Wire Wire Line
	1650 3050 1650 1200
Connection ~ 1650 1200
Wire Wire Line
	1650 1200 7250 1200
Wire Wire Line
	2050 3150 1500 3150
Wire Wire Line
	1500 3150 1500 1000
Connection ~ 1500 1000
Wire Wire Line
	2050 2850 1800 2850
Wire Wire Line
	1800 2850 1800 1400
Wire Wire Line
	1800 1400 7750 1400
Wire Wire Line
	7750 1400 7750 2850
Wire Wire Line
	7750 2850 8100 2850
Text GLabel 3600 3900 2    50   Input ~ 0
DC-Motor_Start
Wire Wire Line
	3450 3900 3600 3900
Text GLabel 10450 5050 2    50   Output ~ 0
-K11:2
Text GLabel 10400 850  2    50   Output ~ 0
-K11:13
Text GLabel 10400 1000 2    50   Output ~ 0
-K11:12
Text GLabel 10400 1200 2    50   Output ~ 0
-K11:11
Text GLabel 10400 1350 2    50   Output ~ 0
-K11:10
Wire Wire Line
	8500 1200 7250 1200
Connection ~ 7250 1200
Wire Wire Line
	10150 850  10400 850 
Wire Wire Line
	10150 1000 10400 1000
Wire Wire Line
	10150 1200 10400 1200
Wire Wire Line
	10400 1350 10150 1350
Wire Wire Line
	10450 5050 10150 5050
Wire Wire Line
	1500 1000 6800 1000
Wire Wire Line
	9100 4650 6800 4650
Wire Wire Line
	6800 4650 6800 1000
Connection ~ 6800 1000
Wire Wire Line
	6800 1000 8500 1000
Wire Wire Line
	9100 4850 7250 4850
Wire Wire Line
	7250 1200 7250 3050
Connection ~ 7250 3050
Wire Wire Line
	7250 3050 7250 4850
Text Notes 9850 5300 2    50   ~ 0
Pullout Motor
$Comp
L Konstruktionswettbewerb-rescue:BlueSmirfSilver -A12
U 1 1 5C1A1E5B
P 4350 4600
F 0 "-A12" H 4578 4551 50  0000 L CNN
F 1 "BlueSmirfSilver" H 4578 4460 50  0000 L CNN
F 2 "" H 4350 4750 50  0001 C CNN
F 3 "" H 4350 4750 50  0001 C CNN
	1    4350 4600
	1    0    0    -1  
$EndComp
Wire Wire Line
	4050 4650 3700 4650
Wire Wire Line
	3700 4650 3700 4000
Wire Wire Line
	3700 4000 3450 4000
Wire Wire Line
	4050 4750 3550 4750
Wire Wire Line
	3550 4750 3550 4100
Wire Wire Line
	3550 4100 3450 4100
Wire Wire Line
	4050 4550 1900 4550
Wire Wire Line
	1900 4550 1900 2750
Wire Wire Line
	1900 2750 2050 2750
Wire Wire Line
	4050 4850 1800 4850
Wire Wire Line
	1800 4850 1800 2950
Wire Wire Line
	1800 2950 2050 2950
Text Notes 4600 5050 2    50   ~ 0
Bluetooth Modul
$EndSCHEMATC
