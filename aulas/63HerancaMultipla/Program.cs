using _63HerancaMultipla.Device;

Printer p = new Printer() { SerialNumber = 1080 };
p.ProcessDoc("My letter");
p.Print("My letter");
Console.WriteLine();

Scanner s = new Scanner() { SerialNumber = 2003 };
s.ProcessDoc("My email");
Console.WriteLine(s.Scan());
Console.WriteLine();

ComboDevice cd = new ComboDevice() { SerialNumber = 3921 };
cd.ProcessDoc("My dissertantion");
cd.Print("My dissertantion");
cd.Scan();