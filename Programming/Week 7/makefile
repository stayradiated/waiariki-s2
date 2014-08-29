.PHONY: main.cs

all : run

main.exe: main.cs
	gmcs main.cs

clean:
	@rm -f *.exe

lint:
	@xmllint --noout --dtdvalid http://www.w3.org/2001/XMLSchema.dtd email.xsd
	@xmllint --schema email.xsd email.xml

run: main.exe
	@mono main.exe
