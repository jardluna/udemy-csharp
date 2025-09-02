using System.Globalization;

/*
 Exemplo 1: Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor.
Em seguida, mostre a altura média dessas pessoas.
 */
Console.WriteLine("-------------------------------------------------------------------------------------------------");

var n = int.Parse(Console.ReadLine());
double[] vetor = new double[n];

double soma = 0;
for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    soma += vetor[i];
}
soma /= n;
Console.WriteLine();
Console.WriteLine($"Altura média: {soma.ToString("f2", CultureInfo.InvariantCulture)}");