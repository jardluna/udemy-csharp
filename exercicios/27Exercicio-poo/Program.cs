using _27Exercicio_poo.Entities;
using System.Globalization;

Console.WriteLine("======================================================================================");

List<Pessoa> lista = new List<Pessoa>();

Console.Write("Entre com o número de PESSOAS: ");
int quant = int.Parse(Console.ReadLine());
Console.WriteLine();

for(int i = 1; i <= quant; i++)
{
    Console.WriteLine($"*** Dados da #{i} PESSOA ***");
    Console.Write("Pessoa Física ou Juridíca (F|J)? ");
    char ch = char.Parse(Console.ReadLine());

    if (ch == 'F')
    {
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        Console.Write("Renda Anual: ");
        double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Gastos com saúde: ");
        double despezaMedica = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
        lista.Add(new PessoaFisica(nome, rendaAnual, despezaMedica));
    }
    else if (ch == 'J')
    {
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        Console.Write("Renda Anual: ");
        double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Número de pessoas: ");
        int numeroPess = int.Parse(Console.ReadLine());
        lista.Add(new PessoaJuridica(nome, rendaAnual, numeroPess));
    }
    Console.WriteLine();
}

double totalImpo = 0.0;

Console.WriteLine("*** IMPOSTOS A PAGAR ***");
foreach (Pessoa item in lista)
{
    Console.WriteLine($"{item.Nome}: ${item.CalcImposto().ToString("f2", CultureInfo.InvariantCulture)}");
    totalImpo += item.CalcImposto();
}
Console.WriteLine();

Console.WriteLine($"Total de Impostos: ${totalImpo.ToString("f2", CultureInfo.InvariantCulture)}");

Console.WriteLine("======================================================================================");