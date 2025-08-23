using _15Exercicio_poo;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler os valores de largura e altura de um retângulo.
            Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
            Usar uma classe como mostrado no material de estudo.
            
            Retangulo r = new Retangulo();

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Entre com a largura e a altura do retângulo");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Área: {r.Area().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro: {r.Perimetro().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal: {r.Diagonal().ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            */

            /*
            Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). 
            Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, 
            aumentar o salário do funcionário com base em uma porcentagem dada 
            (somente o salário bruto é afetado pela porcentagem) 
            e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.
             */

            Funcionario func = new Funcionario();

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Funcionario: {func}");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porc);
            Console.WriteLine($"Dados atualizados: {func}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}
