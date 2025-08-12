//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,
//o valor que recebe por hora e calcular o salário desse funcionário.
//A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horaTrab = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = valorHora * horaTrab;

            Console.WriteLine();
            Console.WriteLine($"Número = {numero}");
            Console.WriteLine($"Sálario = ${salario.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}