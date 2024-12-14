; G-code for Drawing a Circle (Radius 10mm)
; This script uses relative positioning (G91 mode)

; Initial setup
G21 ; Set units to millimeters
G91 ; Switch to relative positioning mode

; Circle drawing parameters

; Start drawing
G1 F1000 ; Set feed rate (adjust as needed)

; Move to start of circle
G1 X0 Y0 ; Move to starting point of circle

; Draw circle using small incremental moves
G2 X0 Y0 I10 J0 F1000 ; Full circle clockwise
; Explanation:
; G2 = Clockwise circular move
; X0 Y0 = Return to start point
; I-[#1] = X offset to circle center (negative because we're in relative mode)
; J0 = Y offset to circle center

; Optional: Return to original position
G90 ; Switch back to absolute positioning
G0 X0 Y0 ; Optional return to origin

M30 ; End of program

; Notes:
; - Adjust feed rate (F1000) as needed for your specific plotter
; - This script uses G2 for a clockwise circle
; - Modify #1 to change radius
; - Modify #2 to adjust circle smoothness (smaller = smoother)
; - G91 (relative) mode means all moves are relative to current position
; - G90 (absolute) mode used for initial and final positioning