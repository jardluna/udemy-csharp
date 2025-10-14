namespace _25Exercicio_poo.Entites
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double CustoAdicional { get; set; }

        public FuncionarioTerceirizado() { }
        public FuncionarioTerceirizado(string nome, int hora, double valorPorHora, double custoAdicional) : base(nome, hora, valorPorHora)
        {
            CustoAdicional = custoAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + CustoAdicional * 1.1;
        }
    }
}
