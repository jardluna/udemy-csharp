using System.Globalization;

Console.WriteLine("*** Acima de R$20 o desconto é de 10%. Abaixo o desconto é 5% ***");
Console.Write("Entre com o valor de um produto: R$");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

double desconto;
desconto = (preco > 20) ? preco * 0.1 : preco * 0.05;
preco -= desconto;

Console.WriteLine($"Desconto de R${desconto.ToString("f2", CultureInfo.InvariantCulture)}");
Console.WriteLine();
Console.WriteLine($"Valor final do produto: R${preco.ToString("f2", CultureInfo.InvariantCulture)}");
