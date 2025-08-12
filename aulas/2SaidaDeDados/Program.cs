using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'f';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia...");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("-------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("f3"));
            Console.WriteLine(saldo.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nome, idade, saldo); //Placeholders
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("f2", CultureInfo.InvariantCulture)} reais"); //Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f2") + " reais"); //Concatenação
        }
    }
}