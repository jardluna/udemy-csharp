using _46ClassesEMetodosSelados.Entities;
using System.Globalization;

namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> lista = new List<Account>();

            lista.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            lista.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            lista.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            lista.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double soma = 0.0;
            foreach (Account item in lista)
            {
                soma += item.Saldo;
            }

            Console.WriteLine($"Saldo total: {soma.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            foreach(Account item in lista)
            {
                item.Saque(10.0);
            }

            foreach(Account item in lista)
            {
                Console.WriteLine($"Saldo atualizado da conta [{item.Numero}]: {item.Saldo.ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}