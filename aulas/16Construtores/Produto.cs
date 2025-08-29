using System.Globalization;

namespace _16Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
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
                    + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture) ;
        }
    }
}
