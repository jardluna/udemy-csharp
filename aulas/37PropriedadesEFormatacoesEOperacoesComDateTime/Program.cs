DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

Console.WriteLine("-----------------------------------------------------------------------------");

//Propriedades
Console.WriteLine("Original: " + d);
Console.WriteLine("1# Data: " + d.Date);
Console.WriteLine("2# Dia: " + d.Day);
Console.WriteLine("3# Dia da Semana: " + d.DayOfWeek);
Console.WriteLine("4# Dia do Ano: " + d.DayOfYear);
Console.WriteLine("5# Hora: " + d.Hour);
Console.WriteLine("6# Tipo: " + d.Kind);
Console.WriteLine("7# Milissegundos: " + d.Millisecond);
Console.WriteLine("8# Minutos:" + d.Minute);
Console.WriteLine("9# Mês: " + d.Month);
Console.WriteLine("10# Segundos: " + d.Second);
Console.WriteLine("11# Ticks: " + d.Ticks);
Console.WriteLine("12# Horário do Dia: " + d.TimeOfDay);
Console.WriteLine("13# Ano: " + d.Year);
Console.WriteLine();

//Formatação
Console.WriteLine("Original: " + d);
Console.WriteLine("[1]: " + d.ToString());
Console.WriteLine("[2]: " + d.ToLongDateString());
Console.WriteLine("[3]: " + d.ToShortDateString());
Console.WriteLine("[4]: " + d.ToLongTimeString());
Console.WriteLine("[5]: " + d.ToShortTimeString());
Console.WriteLine("[6]: " + d.ToBinary());
Console.WriteLine("[7]: " + d.ToFileTime());
Console.WriteLine("[8]: " + d.ToFileTimeUtc());
Console.WriteLine("[9]: " + d.ToLocalTime());
Console.WriteLine("[10]: " + d.ToOADate());
Console.WriteLine("[11]: " + d.ToUniversalTime());
Console.WriteLine("[12]: " + d.ToString("yyyy-MM-dd HH:mm:ss"));
Console.WriteLine("[12]: " + d.ToString("yyyy-MM-dd HH:mm:ss:fff"));
Console.WriteLine();

//Operações
Console.WriteLine("Original: " + d);
Console.WriteLine("(1): " + d.AddDays(3));
Console.WriteLine("(2): " + d.AddHours(3));
Console.WriteLine("(3): " + d.AddMicroseconds(3000000));
Console.WriteLine("(4): " + d.AddMilliseconds(3000));
Console.WriteLine("(5): " + d.AddMinutes(3));
Console.WriteLine("(6): " + d.AddMonths(3));
Console.WriteLine("(7): " + d.AddSeconds(300));
Console.WriteLine("(8): " + d.AddTicks(900000000L));
Console.WriteLine("(9): " + d.AddYears(3));
Console.WriteLine();


DateTime s1 = new DateTime(2015 ,5 ,15, 12, 30, 50);
DateTime s2 = new DateTime(2015, 5, 18, 9, 30, 50);

Console.WriteLine(s1.Subtract(s2));
Console.WriteLine(s2.Subtract(s1));

Console.WriteLine("-----------------------------------------------------------------------------");