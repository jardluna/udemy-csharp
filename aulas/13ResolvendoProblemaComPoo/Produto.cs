using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ResolvendoProblemaComPoo
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quant)
        {
            Quantidade += quant;
        }

        public void RemoverProduto(int quant)
        {
            Quantidade -= quant;
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
