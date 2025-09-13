TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

Console.WriteLine("--------------------------------------------------------------------------");

//Propriedades
Console.WriteLine("**[Original: " + t + "]**");
Console.WriteLine("Ticks: " + t.Ticks);
Console.WriteLine("Milissegundos: " + t.Milliseconds);
Console.WriteLine("Segundos: " + t.Seconds);
Console.WriteLine("Horas: " + t.Hours);
Console.WriteLine("Minutos: " + t.Minutes);
Console.WriteLine("Dias: " + t.Days);
Console.WriteLine();

Console.WriteLine("**[Original: " + t + "]**");
Console.WriteLine("Milissegundos Totais: " + t.TotalMilliseconds);
Console.WriteLine("Segundos Totais: " + t.TotalSeconds);
Console.WriteLine("Horas Totais: " + t.TotalHours);
Console.WriteLine("Minutos Totais: " + t.TotalMinutes);
Console.WriteLine("Dias Totais: " + t.TotalDays);
Console.WriteLine();

//Operações
TimeSpan t1 = new TimeSpan(1, 30, 10);
TimeSpan t2 = new TimeSpan(0, 10, 5);

TimeSpan soma = t1.Add(t2);
TimeSpan dife = t1.Subtract(t2);
TimeSpan mult = t1.Multiply(2);
TimeSpan dive = t1.Divide(2);

Console.WriteLine("**[Original: " + t1 + "]**");
Console.WriteLine("**[Original: " + t2 + "]**");

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Diferença: " + dife);
Console.WriteLine("Multiplicando: " + mult);
Console.WriteLine("Dividindo: " + dive);








Console.WriteLine("--------------------------------------------------------------------------");