using _53ExcecaoPersonalizadaBOA.Entities.Exceptions;
using System.Text;

namespace _53ExcecaoPersonalizadaBOA.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out date must be after Check-In");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkInUpdate, DateTime checkOutUpdate)
        {
            if (checkOutUpdate <= checkInUpdate)
            {
                throw new DomainException ("Check-Out date must be after Check-In");
            }
            if (checkInUpdate <= CheckOut)
            {
                throw new DomainException ("Dates for update must be future dates");
            }

            CheckIn = checkInUpdate;
            CheckOut = checkOutUpdate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Room " + RoomNumber + " | ");
            sb.Append("Check-in: " + CheckIn.ToString("dd/MM/yyyy") + " | ");
            sb.Append("Check-out: " + CheckOut.ToString("dd/MM/yyyy") + " | ");
            sb.Append(Duration() + " Nights");
            return sb.ToString();
        }
    }
}
