using _22_Exercicio_poo.Entities.Enums;

namespace _22_Exercicio_poo.Entities
{
    public class Worker
    {
        public string Nome { get; set; }
        public WorkerLevel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Department Departamento { get; set; }
        public List<HourContract> Contratos { get; set; } = new List<HourContract>();

        public Worker()
        {

        }
        public Worker(string nome, WorkerLevel nivel, double salarioBase, Department departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(HourContract contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoverContrato(HourContract contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Renda(int mes, int ano)
        {
            double soma = SalarioBase;
            foreach (HourContract item in Contratos)
            {
                if (item.Date.Month == mes && item.Date.Year == ano)
                {
                    soma += item.ValorTotal();
                }
            }
            return soma;
        }
    }
}
