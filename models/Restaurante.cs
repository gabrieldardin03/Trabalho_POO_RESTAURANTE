// Restaurante.cs
public class Restaurante : Estabelecimento
{
    // Atributo privado para armazenar o cardápio do restaurante
    private List<Prato> cardapio;

    // Construtor para inicializar os atributos e o cardápio
    public Restaurante(string nome, string endereco, string telefone) : base(nome, endereco, telefone)
    {
        cardapio = new List<Prato>();
    }

    // Método para adicionar um prato ao cardápio
    public void AdicionarPrato(Prato prato)
    {
        cardapio.Add(prato);
    }

    // Método para remover um prato do cardápio
    public void RemoverPrato(Prato prato)
    {
        cardapio.Remove(prato);
    }

    // Método getter para acessar o cardápio
    public List<Prato> GetCardapio()
    {
        return cardapio;
    }
}