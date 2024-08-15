namespace RestaurantePOO;
public class Restaurante : Estabelecimento
{
    public List<Prato> Cardapio { get; set; }

    public Restaurante(string nome, string endereco, string telefone) 
        : base(nome, endereco, telefone)
    {
        Cardapio = new List<Prato>();
    }

    public void AdicionarPrato(Prato prato)
    {
        Cardapio.Add(prato);
    }

    public void RemoverPrato(Prato prato)
    {
        Cardapio.Remove(prato);
    }
}