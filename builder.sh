rm *.o
rm *.elf
rm *.img
rm *.exe
rm *.dll
as -c -o boot.o boot.S
mcs -unsafe kernel.cs -o kernel.exe
mono --aot=asmonly kernel.exe
sed 's/local/globl/g' kernel.exe.s > kernel.s.s
as -o kernel.o kernel.s.s
ld -T link.ld boot.o kernel.o -o kernel.elf -nostdlib
objcopy kernel.elf -O binary kernel.bin
qemu-system-arm -m 128 -M raspi2 -serial stdio -kernel kernel.elf
