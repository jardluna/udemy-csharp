TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(900000000L);
TimeSpan t3 = new TimeSpan(2, 11, 21);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

TimeSpan tf1 = TimeSpan.FromTicks(900000000L);
TimeSpan tf2 = TimeSpan.FromMicroseconds(1.5);
TimeSpan tf3 = TimeSpan.FromMilliseconds(1.5);
TimeSpan tf4 = TimeSpan.FromSeconds(1.5);
TimeSpan tf5 = TimeSpan.FromMinutes(1.5);
TimeSpan tf6 = TimeSpan.FromHours(1.5);
TimeSpan tf7 = TimeSpan.FromDays(1.5);

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);

Console.WriteLine();

Console.WriteLine(tf1);
Console.WriteLine(tf2);
Console.WriteLine(tf3);
Console.WriteLine(tf4);
Console.WriteLine(tf5);
Console.WriteLine(tf6);
Console.WriteLine(tf7);