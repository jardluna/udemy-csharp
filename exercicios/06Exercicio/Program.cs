//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
//o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
//Calcule e mostre o valor a ser pago.

using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(" ");
            string[] vet2 = Console.ReadLine().Split(" ");

            int codigo1 = int.Parse(vet1[0]);
            int quanti1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            int codigo2 = int.Parse(vet2[0]);
            int quanti2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double total = (valor1 * quanti1) + (valor2 * quanti2);

            Console.WriteLine($"Valor a pagar: ${total.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}