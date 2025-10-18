namespace _27Exercicio_poo.Entities
{
    public abstract class Pessoa
    {
        public string? Nome { get; private set; }
        public double RendaAnual { get; private set; }

        public Pessoa() { }
        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcImposto();
    }
}
