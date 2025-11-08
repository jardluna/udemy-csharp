using System.Globalization;

namespace _30Exercicio_poo.Entities
{
    public class Parcelas
    {
        public DateTime Data { get; set; }
        public double ValorContrato { get; set; }

        public Parcelas() { }
        public Parcelas(DateTime data, double valorContrato)
        {
            Data = data;
            ValorContrato = valorContrato;
        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy") + " - " + ValorContrato.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
