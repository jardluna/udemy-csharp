List<string> lista = new List<string>();

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//Add - Insere elementos na lista
lista.Add("Maria");
lista.Add("Alex");
lista.Add("Bob");
lista.Add("Anna");
lista.Add("Joao");
lista.Add("Bia");

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//Insert - Insere elementos na lista na posição desejada
lista.Insert(2, "Marco");

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//Count - Mostra quantas posições (tamanho) a lista tem
Console.WriteLine($"Tamanho da lista: {lista.Count}");

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//Find - Encontrar o primeiro elemento da lista que satisfaça um predicado
string elemento1 = lista.Find(x => x[0] == 'A'); //Expresão lambda

Console.WriteLine($"Primeiro com 'A': {elemento1}");

static bool TesteFind(string s)
{
    return s[0] == 'A';
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//FindLast - Encontrar o último elemento da lista que satisfaça um predicado
string elemento2 = lista.FindLast(x => x[0] == 'A'); //Expresão lambda

Console.WriteLine($"Último com 'A': {elemento2}");

static bool TesteFindLast(string s)
{
    return s[0] == 'A';
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//FindIndex - Encontrar a primeira posição de um elemento da lista que satisfaça um predicado

int pos1 = lista.FindIndex(x => x[0] == 'A');

Console.WriteLine($"Primeira posição com 'A': {pos1}");

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//FindIndex - Encontrar a última posição de um elemento da lista que satisfaça um predicado

int pos2 = lista.FindLastIndex(x => x[0] == 'A');

Console.WriteLine($"Última posição com 'A': {pos2}");

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//FindAll - Filtrar a lista com base em um predicado

List<string> lista2 = lista.FindAll(x => x.Length == 5);

foreach(string item in lista2)
{
    Console.WriteLine(  item);
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//Remove - Remove um elemento da lista

lista.Remove("Alex");

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//RemoveAll - Remove um elemento da lista com base em um predicado

lista.RemoveAll(x => x[0] == 'B');

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//RemoveAt - Remove um elemento da lista com base na sua posição

lista.RemoveAt(2);

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");

//RemoveRange - Remove X(2) elementos da lista apartir da posição Y(1)

lista.RemoveRange(1, 2);

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------------------------------");