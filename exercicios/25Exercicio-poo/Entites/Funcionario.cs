namespace _25Exercicio_poo.Entites
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Hora { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, int hora, double valorPorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Hora * ValorPorHora; 
        }
    }
}
