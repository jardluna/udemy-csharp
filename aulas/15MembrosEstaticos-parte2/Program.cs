using _15MembrosEstaticos_parte2;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA APLICANDO MEMBROS ESTÁTICOS

            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}