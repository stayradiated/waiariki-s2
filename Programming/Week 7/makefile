.PHONY: main.cs

all : run

main.exe: main.cs
	gmcs main.cs

clean:
	@rm -f *.exe

run: main.exe
	@mono main.exe
