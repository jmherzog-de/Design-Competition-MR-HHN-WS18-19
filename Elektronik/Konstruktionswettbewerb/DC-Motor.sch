EESchema Schematic File Version 4
LIBS:Konstruktionswettbewerb-cache
EELAYER 26 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 4 5
Title "DC-Motor Pullout"
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
U 1 1 5C17F1FD
P 9550 2650
F 0 "-M41" H 9708 2646 50  0000 L CNN
F 1 "Pullout Motor" H 9708 2555 50  0000 L CNN
F 2 "" H 9550 2560 50  0001 C CNN
F 3 "~" H 9550 2560 50  0001 C CNN
	1    9550 2650
	1    0    0    -1  
$EndComp
$Comp
L Transistor_BJT:TIP120 -Q41
U 1 1 5C1809B8
P 9450 3500
F 0 "-Q41" H 9657 3546 50  0000 L CNN
F 1 "TIP120" H 9657 3455 50  0000 L CNN
F 2 "Package_TO_SOT_THT:TO-220-3_Vertical" H 9650 3425 50  0001 L CIN
F 3 "http://www.fairchildsemi.com/ds/TI/TIP120.pdf" H 9450 3500 50  0001 L CNN
	1    9450 3500
	1    0    0    -1  
$EndComp
Wire Wire Line
	9550 2950 9550 3300
Text HLabel 8850 4050 0    50   Output ~ 0
GND
Wire Wire Line
	8850 4050 9550 4050
Wire Wire Line
	9550 4050 9550 3700
Text HLabel 8800 2000 0    50   Input ~ 0
+6V
Wire Wire Line
	8800 2000 9550 2000
Wire Wire Line
	9550 2000 9550 2450
Text HLabel 8350 3500 0    50   Input ~ 0
Motor_Start
Wire Wire Line
	8350 3500 9250 3500
$EndSCHEMATC
