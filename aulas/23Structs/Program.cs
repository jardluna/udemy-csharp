using _23Structs;

namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Structs são tipo do tipo VALOR e Classes são do tipo REFERÊNCIA.
            O Struct cria uma cópia de um valor contido em um espaço na memória stack e o atribui a outro espaço da memória.
            A Classe atribui uma referência a uma váriavel na memória stack e faz outra váriavel "apontar" para o mesmo local na mémória heap.
             */
            Ponto p1;
            p1.X = 10;
            p1.Y = 20;
            Console.WriteLine(p1);

            Ponto p2 = new Ponto();
            Console.WriteLine(p2);
        }
    }
}