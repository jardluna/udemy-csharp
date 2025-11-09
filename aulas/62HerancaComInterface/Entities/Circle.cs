using System.Globalization;

namespace _62HerancaComInterface.Entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Circle color: "
                    + Color
                    + " | Radius: "
                    + Radius.ToString("f2", CultureInfo.InvariantCulture)
                    + " | Area: "
                    + Area().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
