using System.Text;

namespace _52ExcecaoPersonalizadaMEDIANA.Entties
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public string UpdateDates(DateTime checkInUpdate, DateTime checkOutUpdate)
        {
            if (checkOutUpdate <= checkInUpdate)
            {
                return "Error in reservation: Check-Out date must be after Check-In";
            }
            if (checkInUpdate <= CheckOut)
            {
                return "Error in reservation: Dates for update must be future dates";
            }

            CheckIn = checkInUpdate;
            CheckOut = checkOutUpdate;
            return null;
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
