public class PedidoPresencial : Pedido
{
    public PedidoPresencial(string numeroPedido) 
        : base(numeroPedido)
    {
    }

    public override decimal CalcularTotal()
    {
        if (Pratos == null)
        {
            throw new InvalidOperationException("Lista de pratos não pode ser nula.");
        }

        decimal total = 0;
        foreach (var prato in Pratos)
        {
            if (prato == null)
            {
                throw new InvalidOperationException("Prato não pode ser nulo.");
            }

            total += prato.ObterPreco();
        }
        return total;
    }
}