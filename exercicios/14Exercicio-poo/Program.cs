using _14Exercicio_poo;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
             */
            Console.WriteLine("------------------------------------------");
            Pessoas a1, b1;
            a1 = new Pessoas();
            b1 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            a1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            b1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a1.Idade > b1.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {a1.Nome} e ele(a) tem {a1.Idade} anos");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é: {b1.Nome} e ele(a) tem {b1.Idade} anos");
            }
            Console.WriteLine("------------------------------------------");


            /*
            Fazer um programa para ler nome e salário de dois funcionários. 
            Depois, mostrar o salário médio dos funcionários.
             */
            Console.WriteLine("------------------------------------------");
            Funcionarios a2, b2;
            a2 = new Funcionarios();
            b2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            a2.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            a2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            b2.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            b2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double salarioMedio = (a2.Salario + b2.Salario) / 2;
            Console.WriteLine($"Sálario médio: {salarioMedio.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("------------------------------------------");

        }
    }
}