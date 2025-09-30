namespace _43Heranca.Entities
{
    public class BusinessAccount : Account
    {
        public double LimiteDeEmprestimo { get; set; }

        public BusinessAccount() { }
        public BusinessAccount(int numero, string titular, double saldo, double limiteDeEmprestimo) : base(numero, titular, saldo)
        {
            LimiteDeEmprestimo = limiteDeEmprestimo;
        }

        public void Emprestimoo(double quantidade)
        {
            if (quantidade <= LimiteDeEmprestimo)
            {
                Saldo += quantidade - 10.0;
            }
        }
    }
}
