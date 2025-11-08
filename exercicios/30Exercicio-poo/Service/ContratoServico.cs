using _30Exercicio_poo.Entities;

namespace _30Exercicio_poo.Service
{
    public class ContratoServico
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ContratoServico(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessamentoContrato(Contrato contrato, int meses)
        {
            double valorParcela = contrato.ValorContrato / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double valorJuros = valorParcela + _servicoPagamentoOnline.Juros(valorParcela, i);
                double valorTaxaPagamento = valorJuros + _servicoPagamentoOnline.TaxaPagamento(valorJuros);
                double valorFinal = valorTaxaPagamento;
                contrato.AddParcelas(new Parcelas(data, valorFinal));
            }
        }
    }
}
