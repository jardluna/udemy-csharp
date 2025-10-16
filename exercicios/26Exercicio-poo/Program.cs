using System.Globalization;
using _26Exercicio_poo.Entities;

Console.WriteLine("==============================================================================");

List<Product> list = new List<Product>();

Console.Write("Entre com a quantidade de produtos: ");
int quantProd = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= quantProd; i++)
{
    Console.WriteLine($"*** Dados do #{i} Produto ***");
    Console.Write("Comum, Usado ou Importado (c|u|i): ");
    char TipoProd = char.Parse(Console.ReadLine());
    if (TipoProd == 'c')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Product(nome, preco));
    }
    else if (TipoProd == 'u')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Data de produção (dd/mm/yyyy): ");
        DateOnly dataProducao = DateOnly.Parse(Console.ReadLine());
        list.Add(new UsedProduct(nome, preco, dataProducao));
    }
    else if (TipoProd == 'i')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Taxa alfandegária: ");
        double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(nome, preco, taxaAlfandega));
    }
    Console.WriteLine();
}

Console.WriteLine("*** TAGS DE PREÇO ***");
foreach (Product item in list)
{
    Console.WriteLine(item.PriceTag());
}

Console.WriteLine("==============================================================================");