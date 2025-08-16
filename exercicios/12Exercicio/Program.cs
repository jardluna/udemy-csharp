namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            EXERCÍCIO 1
            Leia um valor inteiro X. Em seguida mostre os ímpares de 1 até X,
            um valor por linha, inclusive o X, se for o caso.
            
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i1 = 1; i1 <= x1; i1++)
            {
                int r1 = i1 % 2;
                if(r1 != 0)
                {
                    Console.WriteLine(i1);
                }
            }
            */


            /*
            Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo,
            mostrando essas informações conforme exemplo.
            (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
             */

            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int dentro = 0;
            int fora = 0;

            for (int i2 = 1; i2 <= x2; i2++)
            {
                int r2 = int.Parse(Console.ReadLine());
                if (r2 >= 10 && r2 <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }
            Console.WriteLine();

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");

        }
    }
}