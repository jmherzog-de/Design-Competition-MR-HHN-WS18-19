EESchema Schematic File Version 4
LIBS:Konstruktionswettbewerb-cache
EELAYER 26 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 2 5
Title "Power Supply"
Date ""
Rev ""
Comp "DaRRa"
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L Device:Battery -BT2
U 1 1 5BF07CC8
P 1500 2650
F 0 "-BT2" H 1608 2696 50  0000 L CNN
F 1 "1.5V" H 1608 2605 50  0000 L CNN
F 2 "" V 1500 2710 50  0001 C CNN
F 3 "~" V 1500 2710 50  0001 C CNN
	1    1500 2650
	1    0    0    -1  
$EndComp
Text HLabel 2350 1700 2    50   Output ~ 0
+6V
Text HLabel 2800 4000 2    50   Output ~ 0
GND
Wire Wire Line
	1500 2450 1500 2350
$Comp
L Device:Battery -BT1
U 1 1 5C19DE35
P 1500 2150
F 0 "-BT1" H 1608 2196 50  0000 L CNN
F 1 "1,5V" H 1608 2105 50  0000 L CNN
F 2 "" V 1500 2210 50  0001 C CNN
F 3 "~" V 1500 2210 50  0001 C CNN
	1    1500 2150
	1    0    0    -1  
$EndComp
$Comp
L Device:Battery -BT4
U 1 1 5C19DEC3
P 1500 3600
F 0 "-BT4" H 1608 3646 50  0000 L CNN
F 1 "1.5V" H 1608 3555 50  0000 L CNN
F 2 "" V 1500 3660 50  0001 C CNN
F 3 "~" V 1500 3660 50  0001 C CNN
	1    1500 3600
	1    0    0    -1  
$EndComp
Wire Wire Line
	1500 3400 1500 3300
$Comp
L Device:Battery -BT3
U 1 1 5C19DECB
P 1500 3100
F 0 "-BT3" H 1608 3146 50  0000 L CNN
F 1 "1.5V" H 1608 3055 50  0000 L CNN
F 2 "" V 1500 3160 50  0001 C CNN
F 3 "~" V 1500 3160 50  0001 C CNN
	1    1500 3100
	1    0    0    -1  
$EndComp
Wire Wire Line
	1500 2900 1500 2850
Connection ~ 1500 2850
Wire Wire Line
	1500 2850 1500 2800
Wire Wire Line
	1500 1700 2350 1700
Wire Wire Line
	1500 1700 1500 1950
Wire Wire Line
	1500 3800 1500 4000
Wire Wire Line
	1500 4000 2800 4000
$EndSCHEMATC
