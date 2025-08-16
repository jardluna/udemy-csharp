namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------------------------");
            Console.Write("Quantos número você vai digitar? ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int soma = 0;

            for (int i = 1; i <= numero; i++)
            {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine();
            Console.WriteLine($"Soma = {soma}");
            Console.WriteLine("----------------------------------------");
        }
    }
}