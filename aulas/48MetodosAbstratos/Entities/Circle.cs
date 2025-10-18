using _48MetodosAbstratos.Entities.Enums;

namespace _48MetodosAbstratos.Entities
{
    public class Circle : Shape
    {
        public double Raio { get; set; }

        public Circle() { }
        public Circle(Color cor, double raio) : base(cor)
        {
            Raio = raio;
        }

        public sealed override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
