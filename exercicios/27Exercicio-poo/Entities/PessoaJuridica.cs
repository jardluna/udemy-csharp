namespace _27Exercicio_poo.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public int NumeroPess { get; private set; }

        public PessoaJuridica() { }
        public PessoaJuridica(string nome, double rendaAnual, int numeroPess) : base(nome, rendaAnual)
        {
            NumeroPess = numeroPess;
        }

        public sealed override double CalcImposto()
        {
            double calcRenda = 0.0;
            if (NumeroPess <= 10)
            {
                calcRenda = RendaAnual * 0.16;
            }
            else
            {
                calcRenda = RendaAnual * 0.14;
            }
            return calcRenda;
        }
    }
}
