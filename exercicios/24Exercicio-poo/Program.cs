using _24Exercicio_poo.Entities;
using _24Exercicio_poo.Entities.Enums;
using System.Globalization;

Console.WriteLine("======================================================================================");
Console.WriteLine("*** Entre com os dados do CLIENTE ***");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Aniversário (DD/MM/YYYY): ");
DateTime aniversario = DateTime.Parse(Console.ReadLine());
Console.WriteLine();

Cliente cliente = new Cliente(nome, email, aniversario);

Console.WriteLine("*** Entre com os dados do PEDIDO ***");
Console.Write("Status: ");
string statusDoPedido = Console.ReadLine();

Pedido pedido = new Pedido(DateTime.Now, Enum.Parse<StatusDoPedido>(statusDoPedido), cliente);

Console.Write("Serão quantos pedidos: ");
int quant = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= quant; i++)
{
    Console.WriteLine($"Entre com #{i} pedido");
    Console.Write("Nome do produto: ");
    string nomeProduto = Console.ReadLine();
    Console.Write("Preço do produto: ");
    double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantidade: ");
    int quantProduto = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Produto produto = new Produto(nomeProduto, precoProduto);
    ItemDoPedido itemDoPedido = new ItemDoPedido(quantProduto, precoProduto, produto);
    pedido.AdicionarItem(itemDoPedido);
}

Console.WriteLine("----- SUMÁRIO -----");
Console.WriteLine(pedido);

Console.WriteLine("======================================================================================");
Console.WriteLine("======================================================================================");