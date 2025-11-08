namespace _30Exercicio_poo.Entities
{
    public class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorContrato { get; set; }
        public List<Parcelas> Parcelas { get; set; } = new List<Parcelas>();

        public Contrato() { }
        public Contrato(int numero, DateTime data, double valorContrato)
        {
            Numero = numero;
            Data = data;
            ValorContrato = valorContrato;
        }

        public void AddParcelas(Parcelas parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
