using System.Globalization;

namespace _20Exercicio_poo
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario) 
        { 
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += (Salario / 100) * porcentagem;
        }

        public override string ToString()
        {
            return "Id: " 
                + Id 
                + " | " 
                + "Nome: " 
                + Nome 
                + " | " 
                + "Salário: R$" 
                + Salario.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
