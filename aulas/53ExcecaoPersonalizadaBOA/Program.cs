using _53ExcecaoPersonalizadaBOA.Entities;
using _53ExcecaoPersonalizadaBOA.Entities.Exceptions;

Console.WriteLine("====================================================================================");

// SOLUÇÃO BOA

try
{
    Console.Write("Room number: ");
    int roomNumber = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/mm/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date dd/mm/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());
    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

    Console.WriteLine($"Reservatation: {reservation}");
    Console.WriteLine();

    Console.WriteLine("Enter date to update the reservation: ");
    Console.Write("Check-in date (dd/mm/yyyy): ");
    DateTime checkInUpdate = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date dd/mm/yyyy): ");
    DateTime checkOutUpdate = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkInUpdate, checkOutUpdate);

    Console.WriteLine($"Update Reservatation: {reservation}");
}
catch (DomainException e) // Tratamento de exceção personalizada
{
    Console.WriteLine("Error in Reservation: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format Error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected Error: " + e.Message);
}

Console.WriteLine("====================================================================================");