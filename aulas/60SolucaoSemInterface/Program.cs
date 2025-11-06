using _60SolucaoSemInterface.Entities;
using System.Globalization;

Console.WriteLine("Enter Rental Data");

Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/mm/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Pickup (dd/mm/yyyy hh:mm): ");

CarRental carRenta = new CarRental(start, finish, new Vehicle(model));

Console.Write("Enter price per hour: ");
double pricePerHour = double.Parse(Console.ReadLine());
Console.Write("Enter price per day: ");
double pricePerDay =  double.Parse(Console.ReadLine());