G21 ; millimeters
G90 ; absolute coordinate

; Go to safety height
G0 Z1 F100

; Go to zero location
G0 X0 Y0

G0 Z-1 F500


; Create rectangle
G1 X0 Y0 F100
G1 Y10 F100
G1 X10 F100
G1 Y0 F100
G1 X0 F100

G0 Z1 F100
