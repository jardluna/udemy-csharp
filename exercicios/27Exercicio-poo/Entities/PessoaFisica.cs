namespace _27Exercicio_poo.Entities
{
    public class PessoaFisica : Pessoa
    {
        public double DespezaMedica { get; private set; }

        public PessoaFisica() { }
        public PessoaFisica(string nome, double rendaAnual, double despezaMedica) : base(nome, rendaAnual)
        {
            DespezaMedica = despezaMedica;
        }

        public sealed override double CalcImposto()
        {
            double calcRenda = 0.0;
            double calcSaude = 0.0;
            if (RendaAnual <= 20000.0)
            {
                calcRenda = RendaAnual * 0.15;
            }
            else
            {
                calcRenda = RendaAnual * 0.25;
            }

            if (DespezaMedica > 0)
            {
                calcSaude = DespezaMedica / 2;
            }
            return calcRenda - calcSaude;
        }
    }
}
