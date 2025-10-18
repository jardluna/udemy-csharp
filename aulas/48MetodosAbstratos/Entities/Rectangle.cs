using _48MetodosAbstratos.Entities.Enums;

namespace _48MetodosAbstratos.Entities
{
    public class Rectangle : Shape
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Rectangle() { }
        public Rectangle(Color cor, double largura, double altura) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public sealed override double Area()
        {
            return Largura * Altura;
        }
    }
}
