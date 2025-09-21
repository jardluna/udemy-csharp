using _24Exercicio_poo.Entities.Enums;
using System.Globalization;
using System.Text;

namespace _24Exercicio_poo.Entities
{
    public class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusDoPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemDoPedido> Itens { get; set; } = new List<ItemDoPedido>();

        public Pedido()
        {

        }
        public Pedido(DateTime momento, StatusDoPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(ItemDoPedido item)
        {
            Itens.Add(item);
        }
        public void RemoverItem(ItemDoPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (ItemDoPedido item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine();
            sb.AppendLine("Dados do pedido: ");
            foreach (ItemDoPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Preço total: R$" + Total().ToString("f2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
