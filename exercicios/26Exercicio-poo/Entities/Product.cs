using System.Globalization;

namespace _26Exercicio_poo.Entities
{
    public class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product() { }
        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PriceTag()
        {
            return Nome + " $" + Preco.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
