using _20Exercicio_poo;
using System.Globalization;

List<Funcionario> lista = new List<Funcionario>();

Console.WriteLine("-----------------------------------------------------------------------------------------------");

Console.Write("Quantos funcionários serão registrados: ");
int quantFunc = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantFunc; i++)
{
    Console.WriteLine($"*** Funcionário [{i}] ***");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    lista.Add(new Funcionario(id, nome, salario));
    Console.WriteLine();
}

Console.WriteLine("*** Aumento salárial ***");
Console.Write("Informe o Id do funcionário: ");
int idAumento = int.Parse(Console.ReadLine());

Funcionario funcionario = lista.Find(x => x.Id == idAumento);
if (funcionario != null)
{
    Console.Write("Entre com a porcentagem: ");
    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    funcionario.AumentoSalario(porcentagem);
}
else
{
    Console.WriteLine("ESSE ID NÃO EXISTE!");
}
Console.WriteLine();

Console.WriteLine("** Atualização da lista de funcionários ***");
foreach (Funcionario item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------------------------------------------------------------");