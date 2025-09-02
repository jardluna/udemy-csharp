using _26Vetores_parte2;
using System.Globalization;

/*
 Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N produtos.
Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.
 */

int n = int.Parse(Console.ReadLine());
Produto[] vetor = new Produto[n];

double soma = 0;
for (int i = 0; i < n; i++)
{
    string nome = Console.ReadLine();
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vetor[i] = new Produto { Nome = nome, Preco = preco }; //Pode ser instanciado usando um construtor
    soma += vetor[i].Preco;
}

double media = soma / n;
Console.WriteLine();
Console.WriteLine($"Preço médio do produtos: {media.ToString("f2", CultureInfo.InvariantCulture)}");