using _51ExceçõesPersonalizadas.Entities;

Console.WriteLine("====================================================================================");

// SOLUÇÃO RUIM

Console.Write("Room number: ");
int roomNumber = int.Parse(Console.ReadLine());
Console.Write("Check-in date (dd/mm/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());
Console.Write("Check-out date dd/mm/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());
Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

if (checkIn >= checkOut)
{
    Console.WriteLine("Error in reservation: Check-Out date must be after Check-In");
}
else
{
    Console.WriteLine($"Reservatation: {reservation}");
    Console.WriteLine();

    Console.WriteLine("Enter date to update the reservation: ");
    Console.Write("Check-in date (dd/mm/yyyy): ");
    DateTime checkInUpdate = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date dd/mm/yyyy): ");
    DateTime checkOutUpdate = DateTime.Parse(Console.ReadLine());
    reservation.UpdateDates(checkInUpdate, checkOutUpdate);

    if (checkInUpdate <= checkOut)
    {
        Console.WriteLine("Error in reservation: Check-in update date must be later than the previous Check-out date.");
    }
    else
    {
        if (checkInUpdate >= checkOutUpdate)
        {
            Console.WriteLine("Error in reservation: Check-Out date must be after Check-In");
        }
        else
        {
            Console.WriteLine($"Update Reservatation: {reservation}");
        }
    }
}

Console.WriteLine("====================================================================================");