// PedidoDelivery.cs
using System;

public class PedidoDelivery : Pedido
{
    // Atributo privado para armazenar a taxa de entrega
    private decimal taxaDeEntrega;

    // Construtor para inicializar os atributos e a taxa de entrega
    public PedidoDelivery(string numeroPedido) : base(numeroPedido)
    {
        taxaDeEntrega = 10.00m;
    }

    // Método para calcular o total do pedido, incluindo a taxa de entrega
    public override decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var prato in GetPratos())
        {
            total += prato.GetPreco();
        }
        return total + taxaDeEntrega;
    }
}