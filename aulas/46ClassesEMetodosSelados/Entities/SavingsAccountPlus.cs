namespace _46ClassesEMetodosSelados.Entities
{
    public class SavingsAccountPlus : SavingsAccount
    {
        public override void Saque(double quantidade) // Não é possível herdar porque o método Saque da classe SavingsAccount está selado
        {

        }
    }
}
