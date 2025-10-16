using System.Globalization;

namespace _26Exercicio_poo.Entities
{
    public class ImportedProduct : Product
    {
        public double TaxaAlfandega { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string nome, double preco, double taxaAlfandega) : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double TotalPrice()
        {
            return Preco + TaxaAlfandega;
        }

        public sealed override string PriceTag()
        {
            return Nome 
                + " $" + TotalPrice().ToString("f2", CultureInfo.InvariantCulture) 
                + " (Taxa Alfandegária: $" + TaxaAlfandega.ToString("f2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
