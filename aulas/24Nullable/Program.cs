using _24Nullable;
using System.Collections.Concurrent;

//Váriavel do tipo referência (Classe)
Class1 cl = new Class1();
Console.WriteLine(cl.A);

//Váriavel do tipo valor (Struct)
double b = 0;
Console.WriteLine(b);

//Váriavel do tipo referência (Classe) inicializando como "nulo"
Console.WriteLine(cl.C);

//Váriavel do tipo valor (Struct) inicializando como "nulo"
double? d = null; //ou Nullable<double> d = null;
Console.WriteLine(d);

Console.WriteLine("-----------------------------------------------------------------------------------");

/*
 O recurso Nullable tem três operações padrões:
- GetValueOrDefault()
- HasValue
- Value
 */

//Operação que pega o valor atribuido a váriavel ou o seu valor padrão (no caso de um double, o valor 0)
Console.WriteLine(d.GetValueOrDefault());

double? e = 10;
Console.WriteLine(e.GetValueOrDefault());

//Operação que informa se dentro de uma váriavel há algum valor
Console.WriteLine(d.HasValue);
Console.WriteLine(e.HasValue);

//Operação que lança uma exceção se não houver nenhum valor em uma váriavel
if (d.HasValue)
{
    Console.WriteLine(d.Value);
}
else
{
    Console.WriteLine("Váriavel D é nula");
}

if (e.HasValue)
{
    Console.WriteLine(e.Value);
}
else
{
    Console.WriteLine("Váriavel E é nula");
}

Console.WriteLine("-----------------------------------------------------------------------------------");

/*
 O operador de coalescência nula checa se o valor de uma váriavel a ser atribuido a outra váriavel, é nulo ou não.
Caso seja nulo (double f = d ?? 5;), a váriavel "f" recebe o valor 5. E caso não seja nulo (double g = e ?? 5;), 
a váriavel "g" recebe o valor de "e".
 */

//Operador de coalescência nula
double f = d ?? 5;
double g = e ?? 5;
Console.WriteLine(f);
Console.WriteLine(g);