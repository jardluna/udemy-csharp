using System.Net.NetworkInformation;

namespace _46ClassesEMetodosSelados.Entities
{
    public class SavingsAccount : Account
    {
        public double TaxaJuros { get; private set; }

        public SavingsAccount() { }
        public SavingsAccount(string numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void SaldoAtualizado()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public sealed override void Saque(double quantidade)
        {
            Saldo -= quantidade;
        }
    }
}
