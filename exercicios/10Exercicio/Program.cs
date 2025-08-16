/*
 Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
 */

using System.ComponentModel.Design;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Eixo X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Eixo Y: ");
            int y = int.Parse(Console.ReadLine());

            while(x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }

                Console.WriteLine();
                Console.Write("Eixo X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Eixo Y: ");
                y = int.Parse(Console.ReadLine());
               
            }

            Console.WriteLine();
            Console.WriteLine("---- PROGRAMA ENCERRADO ----");

        }
    }
}