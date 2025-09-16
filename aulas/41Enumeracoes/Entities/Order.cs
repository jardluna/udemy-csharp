using _41Enumeracoes.Entities.Enums;

namespace _41Enumeracoes.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Momento + ", " + Status;
        }
    }
}
