Console.WriteLine("--------------------------------------------------------------------------------------");

DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine("d1: " + d1);
Console.WriteLine("d1 kind: " + d1.Kind);
Console.WriteLine("d1 local: " + d1.ToLocalTime());
Console.WriteLine("d1 UTC: " + d1.ToUniversalTime());
Console.WriteLine();

Console.WriteLine("d2: " + d2);
Console.WriteLine("d2 kind: " + d2.Kind);
Console.WriteLine("d2 local: " + d2.ToLocalTime());
Console.WriteLine("d2 UTC: " + d2.ToUniversalTime());
Console.WriteLine();

Console.WriteLine("d2 ToString (errado): " + d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
Console.WriteLine("d2 ToString (certo): " + d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
 
Console.WriteLine("--------------------------------------------------------------------------------------");