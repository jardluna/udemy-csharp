namespace _44Upcasting.Entities
{
    public class BusinessAccount : Account
    {
        public double LimiteEmprestimo { get; set; }

        public BusinessAccount() { }
        public BusinessAccount(int numero, string titulo, double saldo, double limiteEmprestimo) : base(numero, titulo, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantidade)
        {
            if (LimiteEmprestimo >= quantidade)
            {
                Saldo += quantidade;
            }
        }
    }
}
