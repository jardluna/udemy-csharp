using System.Globalization;

namespace _16Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this() //A palavra this referência outro construtor
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) //A palavra this referência outro construtor
        {
            Quantidade = quantidade;
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
            return Nome
                    + ", $"
                    + Preco.ToString("f2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantidade
                    + " unidades. Total: $"
                    + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}