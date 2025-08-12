namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1;
            float b1;

            a1 = 5.1;
            b1 = (float)a1;
            Console.WriteLine(b1);

            Console.WriteLine("---------------------");

            double a2;
            int b2;

            a2 = 5.1;
            b2 = (int)a2;
            Console.WriteLine(b2);

            Console.WriteLine("---------------------");

            int a3 = 5;
            int b3 = 2;
            double resultado1 = a3 / b3;
            double resultado2 = (double)a3 / b3;

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
        }
    }
}