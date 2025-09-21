using System.Globalization;

namespace _24Exercicio_poo.Entities
{
    public class ItemDoPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemDoPedido()
        {

        }
        public ItemDoPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return Produto.Nome 
                + " | R$" 
                + Preco.ToString("f2", CultureInfo.InvariantCulture) 
                + " | Quantidade: " 
                + Quantidade 
                + " | Subtotal: R$" 
                + SubTotal().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
