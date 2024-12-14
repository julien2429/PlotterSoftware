G21
G90
G1 Z5 F300        ; Lift pen up
G0 X0 Y0
G1 Z0 F300        ; Lower pen down
G1 X10 Y40 F500   ; Start drawing the left ear
G1 X20 Y30
G1 X40 Y30
G1 X50 Y40
G1 X60 Y30        ; Complete right ear
G1 X60 Y10
G1 X10 Y10
G1 X10 Y30        ; Complete left side of face
G1 Z5 F300        ; Lift pen up
G0 X20 Y20
G1 Z0 F300        ; Lower pen down
G2 X22 Y20 I1 J0 F500  ; Draw left eye
G1 Z5 F300        ; Lift pen up
G0 X40 Y20
G1 Z0 F300        ; Lower pen down
G2 X42 Y20 I1 J0 F500  ; Draw right eye
G1 Z5 F300        ; Lift pen up
G0 X30 Y15
G1 Z0 F300        ; Lower pen down
G1 X28 Y13 F500   ; Draw left part of nose
G1 X32 Y13        ; Draw right part of nose
G1 X30 Y15        ; Complete nose
G1 Z5 F300        ; Lift pen up
G0 X20 Y13
G1 Z0 F300        ; Lower pen down
G1 X10 Y13 F500   ; Draw left whisker
G1 Z5 F300        ; Lift pen up
G0 X20 Y11
G1 Z0 F300        ; Lower pen down
G1 X10 Y11 F500   ; Draw lower left whisker
G1 Z5 F300        ; Lift pen up
G0 X40 Y13
G1 Z0 F300        ; Lower pen down
G1 X50 Y13 F500   ; Draw right whisker
G1 Z5 F300        ; Lift pen up
G0 X40 Y11
G1 Z0 F300        ; Lower pen down
G1 X50 Y11 F500   ; Draw lower right whisker
G1 Z5 F300        ; Lift pen up
G0 X0 Y0
M30
