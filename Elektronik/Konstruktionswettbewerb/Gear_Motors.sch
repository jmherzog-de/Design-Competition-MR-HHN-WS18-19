EESchema Schematic File Version 4
LIBS:Konstruktionswettbewerb-cache
EELAYER 26 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 4 5
Title "Gear Motors On Left And Right Side"
Date ""
Rev "2"
Comp "DaRRa"
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L Motor:Motor_DC -M?
U 1 1 5C17ED47
P 3150 4950
AR Path="/5BF1A29E/5C17ED47" Ref="-M?"  Part="1" 
AR Path="/5BF1A2A2/5C17ED47" Ref="-M?"  Part="1" 
F 0 "-M?" H 3308 4946 50  0000 L CNN
F 1 "Motor_DC" H 3308 4855 50  0000 L CNN
F 2 "" H 3150 4860 50  0001 C CNN
F 3 "~" H 3150 4860 50  0001 C CNN
	1    3150 4950
	1    0    0    -1  
$EndComp
Text HLabel 2600 4250 0    50   Input ~ 0
+6V
Text HLabel 2400 6750 0    50   Output ~ 0
GND
Text HLabel 2350 5950 0    50   Input ~ 0
Motor_Start
$Comp
L Transistor_FET:FDMS86202ET120 -Q?
U 1 1 5C17ED51
P 3050 5950
AR Path="/5BF1A29E/5C17ED51" Ref="-Q?"  Part="1" 
AR Path="/5BF1A2A2/5C17ED51" Ref="-Q?"  Part="1" 
F 0 "-Q?" H 3255 5996 50  0000 L CNN
F 1 "FDMS86202ET120" H 3255 5905 50  0000 L CNN
F 2 "Package_TO_SOT_SMD:TDSON-8-1" H 3250 5875 50  0001 L CIN
F 3 "https://www.fairchildsemi.com/datasheets/FD/FDMS86202ET120.pdf" V 3050 5950 50  0001 L CNN
	1    3050 5950
	1    0    0    -1  
$EndComp
Wire Wire Line
	2850 5950 2350 5950
Wire Wire Line
	2600 4250 3150 4250
Wire Wire Line
	3150 4250 3150 4750
Wire Wire Line
	3150 5750 3150 5250
Wire Wire Line
	3150 6150 3150 6750
Wire Wire Line
	3150 6750 2400 6750
$EndSCHEMATC
