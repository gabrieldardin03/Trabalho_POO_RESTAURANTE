public class Prato
{
    public string Nome { get; set; }
    public decimal Preco { get; private set; }
    public bool Vegetariano { get; set; }

    public Prato(string nome, decimal preco, bool vegetariano)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentNullException(nameof(nome), "Nome do prato não pode ser nulo ou vazio.");
        }
        if (preco <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(preco), "Preço do prato deve ser maior que zero.");
        }

        Nome = nome;
        Preco = preco;
        Vegetariano = vegetariano;
    }

    public void AtualizarPreco(decimal novoPreco)
    {
        if (novoPreco <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(novoPreco), "Novo preço do prato deve ser maior que zero.");
        }
        Preco = novoPreco;
    }

    public decimal ObterPreco()
    {
        return Preco;
    }
}