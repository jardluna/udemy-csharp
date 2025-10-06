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

        public override void Saque(double quantidade)
        {
            Saldo -= quantidade;
        }

        /*public override void Saque(double quantidade)
        {
            //Dessa forma a sobreposição mantem a regra da superclasse e implementa uma nova regra.
            base.Saque(quantidade);
            Saldo -= 3.0;
        }*/
    }
}
