//Faça um programa para ler o valor do raio de um círculo,
//e depois mostrar o valor da área deste círculo com quatro casas decimais.

using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine($"Área = {area.ToString("f4", CultureInfo.InvariantCulture)}");
        }
    }
}