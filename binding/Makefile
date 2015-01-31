BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=0.2.2

all: WYPopover.dll

WYPopover.dll: Makefile ApiDefinition.cs StructsAndEnums.cs libWYPopoverController.a
	$(MONOXBUILD) /p:Configuration=Release WYPopover.csproj
	cp bin/Release/WYPopover.dll WYPopover.dll

clean:
	-rm -rf list ios *.dll *.zip *.mdb *.sln bin/ obj/