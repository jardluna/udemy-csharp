using System.Globalization;
using System.Text;

namespace _61SolucaoComInterface.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice() { }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Basic payment: " + BasicPayment.ToString("f2", CultureInfo.InvariantCulture));
            sb.AppendLine("Tax: " + Tax.ToString("f2", CultureInfo.InvariantCulture));
            sb.AppendLine("Total payment: " + TotalPayment.ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}