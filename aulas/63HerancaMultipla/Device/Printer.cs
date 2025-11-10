namespace _63HerancaMultipla.Device
{
    public class Printer : AbstractDevice, IPrinter
    {
        public override sealed void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }
        public void Print(string doc)
        {
            Console.WriteLine("Printer print " + doc);
        }
    }
}
