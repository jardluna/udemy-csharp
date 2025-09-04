string[] vetor = new string[] {"Maria", "Bob", "Alex"};

//Percorrendo um vetor com For
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}

Console.WriteLine("--------------------------------------------------------------");

//Percorrendo um vetor com Foreach
foreach (string per in vetor)
{
    Console.WriteLine(per);
}