using _28ModificadorRefEOut;

//Modificador Ref
int a1 = 10;
Calculadora.Triplo(ref a1);
Console.WriteLine(a1);

//Modificador Out
int origem = 15;
int result;
Calculadora.Triplo(origem, out result);
Console.WriteLine(result);