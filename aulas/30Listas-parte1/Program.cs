using System.ComponentModel;

List<string> lista = new List<string>();

Console.WriteLine("---------------------------------------------------------------------------");

//Add - Insere elementos na lista
lista.Add("Maria");
lista.Add("Alex");
lista.Add("Bob");
lista.Add("Anna");

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------");

//Insert - Insere elementos na lista na posição desejada
lista.Insert(2, "Marco");

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------------------------------------------------------------");

//Count - Mostra quantas posições (tamanho) a lista tem
Console.WriteLine($"Tamanho da lista: {lista.Count}");

Console.WriteLine("---------------------------------------------------------------------------");

//Find - Encontrar o primeiro elemento da lista que satisfaça um predicado
string elemento1 = lista.Find(TesteFind); //Sem uso de expressão lambda
//string elemento1 = lista.Find(x => x[0] == 'A'); -> Com uso de expresão lambda

Console.WriteLine($"Primeiro com 'A': {elemento1}");
static bool TesteFind(string s)
{
    return s[0] == 'A';
}

Console.WriteLine("---------------------------------------------------------------------------");

//FindLast - Encontrar o último elemento da lista que satisfaça um predicado
string elemento2 = lista.FindLast(TesteFindLast); ////Sem uso de expressão lambda
//string elemento2 = lista.FindLast(x => x[0] == 'A'); -> Com uso de expresão lambda

Console.WriteLine($"Último com 'A': {elemento2}");

static bool TesteFindLast(string s)
{
    return s[0] == 'A';
}

Console.WriteLine("---------------------------------------------------------------------------");

//FindIndex - Encontrar a primeira posição de um elemento da lista que satisfaça um predicado


Console.WriteLine("---------------------------------------------------------------------------");

//FindLastIndex - Encontrar a última posição de um elemento da lista que satisfaça um predicado



















Console.WriteLine("---------------------------------------------------------------------------");