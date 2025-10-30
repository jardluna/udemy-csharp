try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int result = n1 / n2;

    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Não é possível realizar divisão por ZERO");
}
catch (FormatException e)
{
    Console.WriteLine("Valor de entrada não está no FORMATO (número) correto - " + e.Message);
}