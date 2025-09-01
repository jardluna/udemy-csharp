using _18Exercicio_poo;
using System.Globalization;
Banco bc;

Console.WriteLine("---------------------------------------------------------------------------");

Console.Write("Entre com o número da conta: ");
var numeroConta = int.Parse(Console.ReadLine());
Console.Write("Entre com o nome do títular da conta: ");
var nomeTitular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n): ");
var depSimOuNao = char.Parse(Console.ReadLine());

if (depSimOuNao == 's' || depSimOuNao == 'S')
{
    Console.Write("Entre com o valor do depósito inicial: ");
    var depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    bc = new Banco(numeroConta, nomeTitular, depositoInicial);
}
else
{
    bc = new Banco(numeroConta, nomeTitular);
}

Console.WriteLine();
Console.WriteLine("*** Dados da conta ***");
Console.WriteLine(bc);

Console.WriteLine();
Console.Write("Entre com o valor do depósito: ");
var depositarValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
bc.Deposito(depositarValor);
Console.WriteLine($"*** Dados da conta atualizado ***");
Console.WriteLine(bc);

Console.WriteLine();
Console.Write("Entre com o valor do saque: ");
var sacarValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
bc.Saque(sacarValor);
Console.WriteLine($"*** Dados da conta atualizado ***");
Console.WriteLine(bc);

Console.WriteLine("---------------------------------------------------------------------------");