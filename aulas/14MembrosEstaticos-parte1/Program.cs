using System.Globalization;
using _14MembrosEstaticos_parte1;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA SEM APLICAR MEMBROS ESTÁTICOS

            Calculadora calc = new Calculadora();

            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double vol = calc.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {calc.Pi.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}