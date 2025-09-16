using _41Enumeracoes.Entities;
using _41Enumeracoes.Entities.Enums;

Console.WriteLine("-------------------------------------------------------------------------------------");

Order ordem = new Order {
    Id = 1080,
    Momento = DateTime.Now,
    Status = OrderStatus.PagamentoPendente
};

Console.WriteLine(ordem);

string txt = OrderStatus.PagamentoPendente.ToString(); //Converte do tipo Enumerado para String
OrderStatus os = Enum.Parse<OrderStatus>("Entregue"); //Converte do tipo String para Enumerado

Console.WriteLine(txt);
Console.WriteLine(os);

Console.WriteLine("-------------------------------------------------------------------------------------");