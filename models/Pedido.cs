namespace RestaurantePOO;
public class Pedido
{
    public string NomeRestaurante { get; set; }
    public List<Prato> Pratos { get; set; }

    public Pedido(string nomeRestaurante)
    {
        NomeRestaurante = nomeRestaurante;
        Pratos = new List<Prato>();
    }

    public void AdicionarPrato(Prato prato)
    {
        Pratos.Add(prato);
    }
}