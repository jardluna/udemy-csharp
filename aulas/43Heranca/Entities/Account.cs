namespace _43Heranca.Entities
{
    public class Account
    {
        public int Numero { get; private set; }
        public string? Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Account() { }
        public Account(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade;
        }
        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }
    }
}
