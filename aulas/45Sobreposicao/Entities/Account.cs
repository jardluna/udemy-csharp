namespace _44Upcasting.Entities
{
    public class Account
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public double Saldo { get; set; }

        public Account() { }
        public Account(int numero, string titulo, double saldo)
        {
            Numero = numero;
            Titular = titulo;
            Saldo = saldo;
        }

        public virtual void Saque(double quantidade)
        {
            Saldo -= quantidade + 5.0;
        }
        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }
    }
}
