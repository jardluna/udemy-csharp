using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63HerancaMultipla.Device
{
    public class Scanner : AbstractDevice, IScanner
    {
        public override sealed void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
