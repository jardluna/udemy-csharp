namespace _63HerancaMultipla.Device
{
    public class ComboDevice : AbstractDevice, IScanner, IPrinter
    {
        public override sealed void ProcessDoc(string doc)
        {
            Console.WriteLine("ComboDevice processing: " + doc);
        }
        public string Scan()
        {
            return "ComboDevice scan result";
        }
        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice print " + doc);
        }
    }
}
