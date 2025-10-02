namespace _44Upcasting.Entities
{
    public class SavingsAccount : Account
    {
        public double TaxaJuros { get; set; }

        public SavingsAccount() { }
        public SavingsAccount(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
