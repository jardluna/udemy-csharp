using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
             */

            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i1 = 1; i1 <= x1; i1++)
            {
                string[] vet = Console.ReadLine().Split(" ");
                int n1 = int.Parse(vet[0]);
                int n2 = int.Parse(vet[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    double r1 = (double)n1 / n2;
                    Console.WriteLine($"R: {r1.ToString("f1", CultureInfo.InvariantCulture)}");
                }
                Console.WriteLine();
            }

        }
    }
}