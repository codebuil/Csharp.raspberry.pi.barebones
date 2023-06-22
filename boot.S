.section ".text.boot"
.extern os_oss_Main
.globl _starts
 
        .org 0x8000
_starts:
	
	mov sp, #0x8000
 
 
	
	ldr r4, =__bss_start
	ldr r9, =__bss_end
	mov r5, #0
	mov r6, #0
	mov r7, #0
	mov r8, #0
	b       2f
 
1:
	
	stmia r4!, {r5-r8}
 
	
2:
	cmp r4, r9
	blo 1b
 
	
	ldr r3, =_start
	blx r3
	
halt:
	b halt
