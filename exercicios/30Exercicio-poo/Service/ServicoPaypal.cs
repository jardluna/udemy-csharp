namespace _30Exercicio_poo.Service
{
    public class ServicoPaypal : IServicoPagamentoOnline
    {
        public double TaxaPagamento(double valor)
        {
            return valor * 0.02;
        }
        public double Juros(double valor, int meses)
        {
            return (valor * 0.01) * meses;
        }
    }
}
