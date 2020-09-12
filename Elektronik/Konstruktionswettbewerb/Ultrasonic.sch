EESchema Schematic File Version 4
LIBS:Konstruktionswettbewerb-cache
EELAYER 26 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 3 5
Title "Ultrasonic Distance Sensors"
Date ""
Rev "1"
Comp "DaRRa"
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L Konstruktionswettbewerb-rescue:HC-SR04-Sensor -B31
U 1 1 5BF07E53
P 9550 1150
F 0 "-B31" H 9878 1201 50  0000 L CNN
F 1 "HC-SR04" H 9878 1110 50  0000 L CNN
F 2 "" H 9550 1450 50  0001 C CNN
F 3 "" H 9550 1450 50  0001 C CNN
	1    9550 1150
	1    0    0    -1  
$EndComp
$Comp
L Konstruktionswettbewerb-rescue:HC-SR04-Sensor -B32
U 1 1 5BF07EF6
P 9550 2950
F 0 "-B32" H 9878 3001 50  0000 L CNN
F 1 "HC-SR04" H 9878 2910 50  0000 L CNN
F 2 "" H 9550 3250 50  0001 C CNN
F 3 "" H 9550 3250 50  0001 C CNN
	1    9550 2950
	1    0    0    -1  
$EndComp
$Comp
L Konstruktionswettbewerb-rescue:HC-SR04-Sensor -B33
U 1 1 5BF07FCA
P 9500 4400
F 0 "-B33" H 9828 4451 50  0000 L CNN
F 1 "HC-SR04" H 9828 4360 50  0000 L CNN
F 2 "" H 9500 4700 50  0001 C CNN
F 3 "" H 9500 4700 50  0001 C CNN
	1    9500 4400
	1    0    0    -1  
$EndComp
Wire Wire Line
	9200 950  7250 950 
Wire Wire Line
	7250 950  7250 2750
Wire Wire Line
	7250 2750 9200 2750
Wire Wire Line
	7250 2750 7250 4200
Wire Wire Line
	7250 4200 9150 4200
Connection ~ 7250 2750
Wire Wire Line
	9200 1350 7900 1350
Wire Wire Line
	7900 3150 9200 3150
Wire Wire Line
	7900 1350 7900 3150
Wire Wire Line
	7900 3150 7900 4600
Wire Wire Line
	7900 4600 9150 4600
Connection ~ 7900 3150
Text HLabel 5000 850  0    50   Input ~ 0
+5V
Text HLabel 5000 1150 0    50   Input ~ 0
GND
Wire Wire Line
	5000 850  7250 850 
Wire Wire Line
	7250 850  7250 950 
Connection ~ 7250 950 
Wire Wire Line
	5000 1150 7900 1150
Wire Wire Line
	7900 1150 7900 1350
Connection ~ 7900 1350
Text Notes 9300 850  0    50   ~ 0
"Distance Right"
Text Notes 9300 2650 0    50   ~ 0
"Distance Left"
Text Notes 9200 4100 0    50   ~ 0
"Distance Front"
Text HLabel 4900 1550 0    50   Input ~ 0
Trig_Distance
Wire Wire Line
	9200 1100 7450 1100
Wire Wire Line
	7450 2900 9200 2900
Wire Wire Line
	9150 4350 7450 4350
Wire Wire Line
	7450 4350 7450 2900
Connection ~ 7450 2900
Wire Wire Line
	4900 1550 7450 1550
Wire Wire Line
	7450 1100 7450 1550
Connection ~ 7450 1550
Wire Wire Line
	7450 1550 7450 2900
Text HLabel 8750 1200 0    50   Output ~ 0
Echo_B31
Text HLabel 8900 3000 0    50   Output ~ 0
Echo_B32
Text HLabel 8850 4450 0    50   Output ~ 0
Echo_B33
Wire Wire Line
	8750 1200 9200 1200
Wire Wire Line
	8900 3000 9200 3000
Wire Wire Line
	8850 4450 9150 4450
$EndSCHEMATC
