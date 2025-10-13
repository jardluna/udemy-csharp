namespace _46ClassesEMetodosSelados.Entities
{
    public class Account
    {
        public string? Numero { get; private set; }
        public string? Titular { get; private set; }
        public double Saldo { get; set; }

        public Account() { }
        public Account(string numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque (double quantidade)
        {
            Saldo -= quantidade + 5.0;
        }

        public void Deposito (double quantidade)
        {
            Saldo += quantidade;
        }
    }
}
