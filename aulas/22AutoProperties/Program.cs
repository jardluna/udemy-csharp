using _16Construtores;
using System.Globalization;

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("---------------- Entre com os dados do produto ----------------");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto prod = new Produto(nome, preco, quantidade);

Console.WriteLine($"Dados do produto: {prod}");
Console.WriteLine();

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int add = int.Parse(Console.ReadLine());
prod.AdicionarProduto(add);
Console.WriteLine($"Dados atualizados: {prod}");
Console.WriteLine();

Console.Write("Digite o número de produtos a ser removido do estoque: ");
int rem = int.Parse(Console.ReadLine());
prod.RemoverProduto(rem);
Console.WriteLine($"Dados atualizados: {prod}");

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("---------------------------------------------------------------");