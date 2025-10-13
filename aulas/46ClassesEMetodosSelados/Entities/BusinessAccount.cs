namespace _46ClassesEMetodosSelados.Entities
{
    sealed public class BusinessAccount : Account
    {
        public double LimiteEmprestimo { get; private set; }

        public BusinessAccount() { }
        public BusinessAccount(string numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantidade)
        {
            if(LimiteEmprestimo >= quantidade)
            {
                Saldo += quantidade;
            }
        }
    }
}
