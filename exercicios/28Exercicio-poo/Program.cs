using _28Exercicio_poo.Entities;
using _28Exercicio_poo.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("===============================================================================");

try
{
    Console.WriteLine("ENTER ACCOUNT DATA");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string? holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    Account acc = new Account(number, holder, initialBalance, withdrawLimit);

    Console.Write("Enter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    acc.Withdraw(withdraw);

    Console.WriteLine(acc);
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw Error: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine($"Format Error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error");
}

Console.WriteLine("===============================================================================");