using System.Globalization;

namespace _16Construtores
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                    + ", $"
                    + Preco.ToString("f2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantidade
                    + " unidades. Total: $"
                    + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}