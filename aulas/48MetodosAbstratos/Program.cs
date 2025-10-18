using _48MetodosAbstratos.Entities;
using _48MetodosAbstratos.Entities.Enums;
using System.Globalization;

Console.WriteLine("===========================================================================");

List<Shape> lista = new List<Shape>();

Console.Write("Entre com a quantidade de FORMAS: ");
int quantidade = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= quantidade; i++)
{
    Console.WriteLine($"*** #{i} Forma ***");

    Console.Write("Retângulo ou Círculo (r|c)? ");
    char RetOuCir = char.Parse(Console.ReadLine());
    Console.Write("Cor (Preto|Azul|Vermelho)? ");
    string? cor = Console.ReadLine();

    if (RetOuCir == 'r')
    {
        Console.Write("Largura: ");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        lista.Add(new Rectangle(Enum.Parse<Color>(cor), largura, altura));
    }
    else if (RetOuCir == 'c')
    {
        Console.Write("Raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        lista.Add(new Circle(Enum.Parse<Color>(cor), raio));
    }
    Console.WriteLine();
}

Console.WriteLine("*** Área das FORMAS ***");
foreach (Shape item in lista)
{
    Console.WriteLine(item.Area().ToString("f2", CultureInfo.InvariantCulture));
}

Console.WriteLine("===========================================================================");