using System.Globalization;

namespace _18Exercicio_poo
{
    class Banco
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoConta { get; private set; }

        public Banco() { }
        public Banco(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }
        public Banco(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double depositarValor)
        {
            SaldoConta += depositarValor;
        }
        public void Saque(double sacarValor)
        {
            SaldoConta -= sacarValor + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                    + NumeroConta
                    + " | Titular: "
                    + NomeTitular
                    + " | Saldo: $"
                    + SaldoConta.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
