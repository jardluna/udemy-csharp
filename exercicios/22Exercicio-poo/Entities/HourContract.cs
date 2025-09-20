namespace _22_Exercicio_poo.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public HourContract()
        {

        }
        public HourContract(DateTime date, double valorPorHora, int horasTrabalhadas)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * HorasTrabalhadas;
        }
    }
}
