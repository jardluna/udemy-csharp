namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 1 && hora < 6)
            {
                Console.WriteLine("Boa noite!");
            }
            else if (hora >= 6 && hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else if (hora >= 18 && hora <= 24)
            {
                Console.WriteLine("Boa Noite!");
            }
            else if (hora <= 0 || hora > 24)
            {
                Console.WriteLine("Hora não existe...");
            }

        }
    }
}