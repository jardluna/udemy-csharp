using System.Globalization;

Console.WriteLine("----------------------------------------------------------------------------------------");

DateTime d1 = new DateTime(2025, 04, 07); //Ano, mês e dia
DateTime d2 = new DateTime(2025, 04, 07, 22, 32, 40); //Ano, mês, dia, hora, minutos e segundos
DateTime d3 = new DateTime(2025, 04, 07, 22, 32, 40, 500); ////Ano, mês, dia, hora, minutos, segundos e milissegundos

DateTime d4 = DateTime.Now;
DateTime d5 = DateTime.Today;
DateTime d6 = DateTime.UtcNow;

DateTime d7 = DateTime.Parse("1999-04-07");
DateTime d8 = DateTime.Parse("1999-04-07 12:45:20");
DateTime d9 = DateTime.Parse("07/04/1999");
DateTime d10 = DateTime.Parse("07/04/1999 12:45:20");
DateTime d11 = DateTime.ParseExact("1999-04-07", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d12 = DateTime.ParseExact("14/04/1960 22:50:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine($"D1: {d1}");
Console.WriteLine($"D2: {d2}");
Console.WriteLine($"D3: {d3}");
Console.WriteLine($"D4: {d4}");
Console.WriteLine($"D5: {d5}");
Console.WriteLine($"D6: {d6}");
Console.WriteLine($"D7: {d7}");
Console.WriteLine($"D8: {d8}");
Console.WriteLine($"D9: {d9}");
Console.WriteLine($"D10: {d10}");
Console.WriteLine($"D11: {d11}");
Console.WriteLine($"D12: {d12}");

Console.WriteLine("----------------------------------------------------------------------------------------");
