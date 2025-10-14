using System.Globalization;
using _25Exercicio_poo.Entites;

Console.WriteLine("===================================================================================");

List<Funcionario> list = new List<Funcionario>();

Console.Write("Entre com o número de funcioários: ");
int numFunc = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= numFunc; i++)
{
    Console.WriteLine($"*** Dados Do #{i} Funcionário ***");
    Console.Write("Terceirizado (s/n)? ");
    char simOuNao = char.Parse(Console.ReadLine());

    if (simOuNao == 's')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Hora: ");
        int hora = int.Parse(Console.ReadLine());
        Console.Write("Valor por hora: ");
        double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Custo Adicional: ");
        double custoAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new FuncionarioTerceirizado(nome, hora, valorPorHora, custoAdicional));
    }
    else if (simOuNao == 'n')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Hora: ");
        int hora = int.Parse(Console.ReadLine());
        Console.Write("Valor por hora: ");
        double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Funcionario(nome, hora, valorPorHora));
    }
    else
    {
        Console.WriteLine("PROGRAMA ENCERRADO");
    }
    Console.WriteLine();
}

Console.WriteLine("PAGAMENTOS");
foreach (Funcionario item in list)
{
    Console.WriteLine($"{item.Nome} - ${item.Pagamento().ToString("f2", CultureInfo.InvariantCulture)}");
}

Console.WriteLine("===================================================================================");