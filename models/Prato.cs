// Prato.cs
public class Prato
{
    private decimal preco;
    public string Nome { get; set; }
    public bool Vegetariano { get; set; }

    public Pratos(string nome, decimal preco, bool vegetariano)
    {
        Nome = nome;
        this.preco = preco;
        Vegetariano = vegetariano;
    }

    public void AtualizarPreco(decimal novoPreco)
    {
        if (novoPreco > 0)
        {
            preco = novoPreco;
        }
        else
        {
            throw new ArgumentException("O preço deve ser maior que zero.");
        }
    }

    public decimal ObterPreco()
    {
        return preco;
    }
}