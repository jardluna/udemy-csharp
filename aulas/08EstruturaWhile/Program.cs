using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            double resposta = Validador(numero);

            if (resposta < 0)
            {
                Console.WriteLine("Número NEGATIVO!");
            }
        }
        static double Validador(double a)
        {
            double b;
            while (a >= 0)
            {
                double raiz = Math.Sqrt(a);
                Console.WriteLine($"A raiz do número é {raiz.ToString("f3", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
                Console.Write("Digite outro número: ");
                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            b = a;
            return b;
        }
    }
}