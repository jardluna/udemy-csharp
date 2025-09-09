Console.WriteLine("--------------------------------------------------------------------------------------");
Console.WriteLine();

Console.Write("Quantas linhas: ");
int linha = int.Parse(Console.ReadLine());
Console.Write("Quantas colunas: ");
int coluna = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matriz = new int[linha, coluna];

for (int l = 0; l < linha; l++)
{
    string[] vetor = Console.ReadLine().Split(' ');
    for (int c = 0; c < coluna; c++)
    {
        matriz[l, c] = int.Parse(vetor[c]);
    }
}
Console.WriteLine();

for (int l = 0; l < linha; l++)
{
    for (int c = 0; c < coluna; c++)
    {
        Console.Write(matriz[l, c] + " | ");
    }
}
Console.WriteLine();
Console.WriteLine();

Console.Write("Digite um número para encontrar: ");
int encoNume = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int l = 0; l < linha; l++)
{
    for (int c = 0; c < coluna; c++)
    {
        if (matriz[l, c] == encoNume)
        {
            Console.WriteLine($"*** Posição [{l + 1},{c + 1}] ***");
            //Valor da esquerda
            if (c > 0)
            {
                Console.WriteLine($"Esquerda: {matriz[l, c - 1]}");
            }
            //Valor abaixo
            if (l < linha - 1)
            {
                Console.WriteLine($"Abaixo: {matriz[l + 1, c]}");
            }
            //Valor da direita
            if (c < coluna - 1)
            {
                Console.WriteLine($"Direita: {matriz[l, c + 1]}");
            }
            //Valor acima
            if (l > 0)
            {
                Console.WriteLine($"Acima: {matriz[l - 1, c]}");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("--------------------------------------------------------------------------------------");