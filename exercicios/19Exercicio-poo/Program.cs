using _19Exercicio_poo;

Console.WriteLine("---------------------------------------------------------------------------------------");

var totalQuartos = 10;
Servico[] vetor = new Servico[totalQuartos];

Console.Write("Quantos quartos serão alugados: ");
var quantidade = int.Parse(Console.ReadLine());
Console.WriteLine();

for (var i = 1; i <= quantidade; i++)
{
    Console.WriteLine($"Aluguel #{i}");
    Console.Write("Nome: ");
    var nome = Console.ReadLine();
    Console.Write("Email: ");
    var email = Console.ReadLine();
    Console.Write("Quarto: ");
    var quarto = int.Parse(Console.ReadLine());
    vetor[quarto] = new Servico(nome, email, quarto);
    Console.WriteLine();
}

Console.WriteLine("*** Quartos Alugados ***");
for (var i = 0; i < totalQuartos; i++)
{
    if (vetor[i] != null)
    {
        Console.WriteLine(vetor[i]);
    }
}

Console.WriteLine("---------------------------------------------------------------------------------------");