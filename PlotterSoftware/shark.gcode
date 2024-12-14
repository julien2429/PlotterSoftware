
G21 ; Set units to mm
G90 ; Set absolute positioning
G1 F500 
; Move to starting position
G0 X15 Y60 Z0 ; Pen up
G0 X30 Y80 ; Move to start of drawing

; Shark body outline (approximation)
G1 Z10 ; Pen down
G1 X50 Y90 ; Draw dorsal fin
G1 X90 Y70 ; Draw body curve
G1 X120 Y80 ; Draw upper body to tail fin
G1 X140 Y60 ; Draw upper tail fin
G1 X120 Y40 ; Draw lower tail fin
G1 X90 Y50 ; Draw lower body curve
G1 X50 Y30 ; Draw bottom to pectoral fin
G1 X30 Y50 ; Draw lower curve to mouth
G1 X30 Y80 ; Return to start of body

; Eye (simple circle approximation)
G0 X55 Y75 Z0 ; Move to eye position (pen up)
G1 Z10 ; Pen down
G1 X57 Y76 ; Draw eye circle
G1 X59 Y75
G1 X57 Y74
G1 X55 Y75

; Pen up and return home
G0 Z0 ; Pen up
G0 X0 Y0 ; Return to origin

M30 ; End program
