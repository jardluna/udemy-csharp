using _62HerancaComInterface.Entities.Interfaces;
using System.Drawing;

namespace _62HerancaComInterface.Entities
{
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
