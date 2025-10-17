namespace _46ClassesEMetodosSelados.Entities
{
    public class SavingsAccount : Account
    {
        public double TaxaJuros { get; private set; }

        public SavingsAccount() { }
        public SavingsAccount(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void SaldoAtualizado()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public sealed override void Saque(double quantidade)
        {
            base.Saque(quantidade);
            Saldo -= 2.0;
        }
    }
}