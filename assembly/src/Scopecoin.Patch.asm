;==================================================================================================
; Spawn rupee
;==================================================================================================

.headersize G_EN_SCOPECOIN_DELTA

; Replaces:
;   jal     0x800A7730
;   addiu   a1, a1, 0x0024
.org 0x80BFCFF0
    jal     Scopecoin_RupeeSpawn
    nop