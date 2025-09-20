using _22_Exercicio_poo.Entities;
using _22_Exercicio_poo.Entities.Enums;
using System.Globalization;

Console.WriteLine("====================================================================");

Console.Write("Entre com o nome do departamento: ");
string nomeDepartamento = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("=== Entre com os dados do trabalhador ===");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Nivel (Junior/Pleno/Senior): ");
string nivel = Console.ReadLine();
Console.Write("Salário base: ");
double salarioBase = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
Console.WriteLine();

Worker worker = new Worker(nome, Enum.Parse<WorkerLevel>(nivel), salarioBase, new Department(nomeDepartamento));

Console.Write("Quantos contratos o trabalhados tem? ");
int quantidadeContrato = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantidadeContrato; i++)
{
    Console.WriteLine($"=== Entre com o #{i} contrato ===");
    Console.Write("Data (DD/MM/YYYY): ");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por hora: ");
    double valorPorHora = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
    Console.Write("Horas trabalhadas: ");
    int horasTrabalhadas = int.Parse(Console.ReadLine());
    HourContract hourContract = new HourContract(data, valorPorHora, horasTrabalhadas);
    worker.AdicionarContrato(hourContract);
    Console.WriteLine();
}

Console.Write("Entre com o mês e o ano para calcular a renda (MM/YYYY): ");
string mesEAno = Console.ReadLine();
int mes = int.Parse(mesEAno.Substring(0, 2));
int ano = int.Parse(mesEAno.Substring(3));

Console.WriteLine("Nome: " + worker.Nome);
Console.WriteLine("Departamento: " + worker.Departamento.NomeDepartamento);
Console.WriteLine($"Renda de {mes}/{ano}: {worker.Renda(mes, ano).ToString("f2", CultureInfo.InvariantCulture)}");

Console.WriteLine("====================================================================");