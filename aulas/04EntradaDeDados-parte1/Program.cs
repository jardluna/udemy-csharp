namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1 = Console.ReadLine();
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            string z1 = Console.ReadLine();
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Você digitou: {frase1}");
            Console.WriteLine($"Você digitou: {x1}");
            Console.WriteLine($"Você digitou: {y1}");
            Console.WriteLine($"Você digitou: {z1}");
            Console.WriteLine($"Você digitou: {a1}");
            Console.WriteLine($"Você digitou: {b1}");
            Console.WriteLine($"Você digitou: {c1}");

            Console.WriteLine("-------------------------------");

            string[] vet1 = Console.ReadLine().Split(' '); //Entrada de dados com vetor
            string x2 = vet1[0];
            string y2 = vet1[1];
            string z2 = vet1[2];

            string[] vet2 = Console.ReadLine().Split(' '); //Entrada de dados com vetor
            string a2 = vet1[0];
            string b2 = vet1[1];
            string c2 = vet1[2];
            Console.WriteLine();

            Console.WriteLine($"Você digitou: {x2}");
            Console.WriteLine($"Você digitou: {y2}");
            Console.WriteLine($"Você digitou: {z2}");
            Console.WriteLine($"Você digitou: {a2}");
            Console.WriteLine($"Você digitou: {b2}");
            Console.WriteLine($"Você digitou: {c2}");

        }
    }
}