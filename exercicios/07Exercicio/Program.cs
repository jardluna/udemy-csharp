//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,
//sabendo que o mesmo pode começar em um dia e terminar em outro,
//tendo uma duração mínima de 1 hora e máxima de 24 horas.

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int r = 0;

            if (n1 > n2)
            {
                int dif = n1 - n2;
                r = 24 - dif;
            }
            else if (n1 < n2)
            {
                int dif1 = 24 - n1;
                int dif2 = 24 - n2;
                r = dif1 - dif2;
            }
            else if (n1 == n2)
            {
                r = 24;
            }

            Console.WriteLine($"O jogo durou {r} horas");
        }
    }
}