.PHONY: delegates.cs

all : run

delegates.exe: delegates.cs
	gmcs delegates.cs

clean:
	@rm -f *.exe

run: delegates.exe
	@mono delegates.exe
