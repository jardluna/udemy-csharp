using _16Exercicio_poo;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler o nome de um aluno e as quatro notas que ele obteve nos quatro bimestres do ano. 
            Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, 
            em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos).
            Em caso de nota maior que 100, avisar que a nota é inválida e perguntar novamente até uma nota certa ser digitada.
            Você deve criar uma classe Aluno para resolver este problema.
            */

            Aluno aluno = new Aluno();

            Console.WriteLine("-----------------------------------------|");
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("**** Digite as quatro notas do aluno ****");

            Console.Write("1# nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (aluno.Nota1 > 100)
            {
                while (aluno.Nota1 > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("NOTA INVÁLIDA");
                    Console.Write("DIGITE UMA NOTA ATÉ 100 PONTOS: ");
                    aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                Console.WriteLine();
            }

            Console.Write("2# nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (aluno.Nota2 > 100)
            {
                while (aluno.Nota2 > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("NOTA INVÁLIDA");
                    Console.Write("DIGITE UMA NOTA ATÉ 100 PONTOS: ");
                    aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                Console.WriteLine();
            }

            Console.Write("3# nota: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (aluno.Nota3 > 100)
            {
                while (aluno.Nota3 > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("NOTA INVÁLIDA");
                    Console.Write("DIGITE UMA NOTA ATÉ 100 PONTOS: ");
                    aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                Console.WriteLine();
            }

            Console.Write("4# nota: ");
            aluno.Nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (aluno.Nota4 > 100)
            {
                while (aluno.Nota4 > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("NOTA INVÁLIDA");
                    Console.Write("DIGITE UMA NOTA ATÉ 100 PONTOS: ");
                    aluno.Nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Nota final do(a) aluno(a): {aluno.Nome} foi {aluno.NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}");
            if (aluno.AprovadoOuReprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltaram {aluno.NotaRestante().ToString("f2", CultureInfo.InvariantCulture)} pontos");
            }
            Console.WriteLine("-----------------------------------------|");
        }
    }
}