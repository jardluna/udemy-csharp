using System.Globalization;

namespace _26Exercicio_poo.Entities
{
    public class UsedProduct : Product
    {
        public DateOnly DataProducao { get; set; }

        public UsedProduct() { }
        public UsedProduct(string nome, double preco, DateOnly dataProducao) : base(nome, preco)
        {
            DataProducao = dataProducao;
        }

        public sealed override string PriceTag()
        {
            return Nome 
                + " (usado) $" + Preco.ToString("f2", CultureInfo.InvariantCulture) 
                + " (Produzido dia: " + DataProducao + ")";
        }
    }
}
