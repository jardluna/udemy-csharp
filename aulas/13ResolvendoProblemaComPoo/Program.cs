using System.Globalization;

using _13ResolvendoProblemaComPoo;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine();
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do produto:" + p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            var add = int.Parse(Console.ReadLine());
            p.AdicionarProduto(add);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            var rev = int.Parse(Console.ReadLine());
            p.RemoverProduto(rev);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("--------------------------------");

        }
    }
}