EESchema Schematic File Version 4
LIBS:Konstruktionswettbewerb-cache
EELAYER 26 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 5 5
Title "Brushless Motor \"Throw Out\""
Date ""
Rev "1"
Comp "DaRRa"
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L Motor:Motor_DC -M41
U 1 1 5C147FBF
P 8600 2250
F 0 "-M41" H 8758 2246 50  0000 L CNN
F 1 "Motor_DC" H 8758 2155 50  0000 L CNN
F 2 "" H 8600 2160 50  0001 C CNN
F 3 "~" H 8600 2160 50  0001 C CNN
	1    8600 2250
	1    0    0    -1  
$EndComp
Text HLabel 8050 1550 0    50   Input ~ 0
+5V
Text HLabel 7850 4050 0    50   Output ~ 0
GND
Text HLabel 7800 3250 0    50   Input ~ 0
Motor_Start
$Comp
L Transistor_FET:FDMS86202ET120 -Q42
U 1 1 5C148076
P 8500 3250
F 0 "-Q42" H 8705 3296 50  0000 L CNN
F 1 "FDMS86202ET120" H 8705 3205 50  0000 L CNN
F 2 "Package_TO_SOT_SMD:TDSON-8-1" H 8700 3175 50  0001 L CIN
F 3 "https://www.fairchildsemi.com/datasheets/FD/FDMS86202ET120.pdf" V 8500 3250 50  0001 L CNN
	1    8500 3250
	1    0    0    -1  
$EndComp
Wire Wire Line
	8300 3250 7800 3250
Wire Wire Line
	8050 1550 8600 1550
Wire Wire Line
	8600 1550 8600 2050
Wire Wire Line
	8600 3050 8600 2550
Wire Wire Line
	8600 3450 8600 4050
Wire Wire Line
	8600 4050 7850 4050
$EndSCHEMATC
