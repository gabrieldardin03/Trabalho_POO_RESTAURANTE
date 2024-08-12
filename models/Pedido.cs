public abstract class Pedido : Prato
{
    public string NumeroPedido { get; set; }
    public string Endereco { get; set; }
    public abstract decimal CalcularTotal { get; set; }
    public string Prato{get; set; }

    }
