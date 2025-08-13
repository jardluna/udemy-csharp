/*
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação.
*/

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string resp = "";

            if (x > 0 && y > 0)
            {
                resp = "Q1";
            }
            else if (x < 0 && y > 0)
            {
                resp = "Q2";
            }
            else if (x < 0 && y < 0)
            {
                resp = "Q3";
            }
            else if (x > 0 && y < 0)
            {
                resp = "Q4";
            }
            else if (x == 0 && y == 0)
            {
                resp = "Origem";
            }
            else if (x == 0 && y != 0)
            {
                resp = "Eixo X";
            }
            else if (y == 0 && x != 0)
            {
                resp = "Eixo Y";
            }

            Console.WriteLine(resp);

        }
    }
}