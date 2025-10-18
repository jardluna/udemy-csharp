using _48MetodosAbstratos.Entities.Enums;

namespace _48MetodosAbstratos.Entities
{
    public abstract class Shape
    {
        public Color Cor { get; set; }

        public Shape() { }
        public Shape(Color cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
