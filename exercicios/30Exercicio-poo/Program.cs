using _30Exercicio_poo.Entities;
using _30Exercicio_poo.Service;
using System.Globalization;

Console.WriteLine("========================================================================================");

Console.WriteLine("ENTRE COM OS DADOS DO CONTRATO");
Console.WriteLine();

Console.Write("Número: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Data (dd/mm/yyyy): ");
DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Valor do contrato: ");
double valorContrato = double.Parse(Console.ReadLine());
Console.Write("Número de parcelas: ");
int quantidadeParcelas = int.Parse(Console.ReadLine());
Console.WriteLine();

Contrato contrato = new Contrato(numero, data, valorContrato);

ContratoServico contratoServico = new ContratoServico(new ServicoPaypal());

contratoServico.ProcessamentoContrato(contrato, quantidadeParcelas);

Console.WriteLine("PARCELAS");
foreach (Parcelas parcela in contrato.Parcelas)
{
    Console.WriteLine(parcela);
}

Console.WriteLine("========================================================================================");