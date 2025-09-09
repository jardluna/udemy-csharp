/*
double[,] matriz = new double[4, 5];

//Length - Mostra a quantidade de posições que a matriz possui
Console.WriteLine(matriz.Length);

//Rank - Mostra a quantidade de dimensões que a matriz possui
Console.WriteLine(matriz.Rank);

//GetLenght - Mostra a quantidade de posições dentro de uma dimensão da matriz
Console.WriteLine(matriz.GetLength(1));
*/

int n = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, n];
Console.WriteLine();

//---------------------------------------------------------------------------------------

for (int linha = 0; linha < n; linha++)
{
    string[] vetor = Console.ReadLine().Split(' ');
    for (int coluna = 0; coluna < n; coluna++)
    {
        matriz[linha, coluna] = int.Parse(vetor[coluna]);
    }
}
Console.WriteLine();

//---------------------------------------------------------------------------------------

Console.WriteLine("*** Diagonal pricipal ***");
for (int i = 0; i < n; i++)
{
    Console.Write(matriz[i, i] + " ");
}
Console.WriteLine();
Console.WriteLine();

//---------------------------------------------------------------------------------------

int contador = 0;
Console.WriteLine("*** Números negativos ***");
for (int linha = 0; linha < n; linha++)
{
    for (int coluna = 0; coluna < n; coluna++)
    {
        if (matriz[linha, coluna] < 0)
        {
            contador++;
        }
    }
}
Console.WriteLine($"A matriz possui [{contador}] números negativos");

Console.Write("---> ");
for (int linha = 0; linha < n; linha++)
{
    for (int coluna = 0; coluna < n; coluna++)
    {
        if (matriz[linha, coluna] < 0)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
}