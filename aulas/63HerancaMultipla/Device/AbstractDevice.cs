namespace _63HerancaMultipla.Device
{
    public abstract class AbstractDevice
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc);
    }
}
