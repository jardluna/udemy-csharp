using _60SolucaoSemInterface.Entities;
using _60SolucaoSemInterface.Services;
using System.Globalization;

Console.WriteLine("====================================================================================");

Console.WriteLine("Enter Rental Data");

Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/mm/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine();

Console.Write("Enter price per hour: ");
double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

rentalService.ProcessInvoice(carRental);

Console.WriteLine();
Console.WriteLine("INVOICE");
Console.WriteLine(carRental.Invoice);

Console.WriteLine();
Console.WriteLine(rentalService.Teste(carRental));

Console.WriteLine("====================================================================================");