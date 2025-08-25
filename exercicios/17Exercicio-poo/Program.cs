using _17Exercicio_poo;

using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa para ler a cotação do dolar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
            Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF
            sobre o valor em dólar. Criar uma classe ConversorDeMoedas para ser responsável pelos cálculos.
             */

            Console.WriteLine("---------------------------------------------------");
            Console.Write("Qual a cotação do DOLAR: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos DÓLARES você vai comprar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Valor a ser pago em REAIS: {ConversorDeMoeda.Calculo(cotacao, dolar).ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("---------------------------------------------------");
        }
    }
}