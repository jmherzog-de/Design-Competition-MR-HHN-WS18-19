EESchema Schematic File Version 4
LIBS:PWRsch-cache
EELAYER 26 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 1
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L Device:Battery -U1
U 1 1 5BF07A83
P 1800 2750
F 0 "-U1" H 1908 2796 50  0000 L CNN
F 1 "Battery" H 1908 2705 50  0000 L CNN
F 2 "" V 1800 2810 50  0001 C CNN
F 3 "~" V 1800 2810 50  0001 C CNN
	1    1800 2750
	1    0    0    -1  
$EndComp
Wire Wire Line
	1800 2950 1800 3150
Text HLabel 2650 2100 2    50   Output ~ 0
+9V
Text HLabel 2750 3150 2    50   Output ~ 0
GND
Wire Wire Line
	2650 2100 1800 2100
Wire Wire Line
	1800 2100 1800 2550
Wire Wire Line
	1800 3150 2750 3150
$EndSCHEMATC
