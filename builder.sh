rm *.o
rm *.elf
rm *.img
rm *.exe
rm *.dll
as -c -o boot.o boot.S
mcs -t:library -unsafe kernel.cs -o kernel.dll
mkbundle --static -o kernel.o kernel.dll
#mono --aot=static kernel
ld -T link.ld boot.o kernel.o -o kernel.elf -nostdlib
objcopy kernel.elf -O binary kernel.img
qemu-system-arm -m 128 -M raspi2 -serial stdio -kernel kernel.elf
