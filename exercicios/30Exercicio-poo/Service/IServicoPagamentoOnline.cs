namespace _30Exercicio_poo.Service
{
    public interface IServicoPagamentoOnline
    {
        public double TaxaPagamento(double valor);
        public double Juros(double valor, int meses);

    }
}
