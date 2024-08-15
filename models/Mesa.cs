// Mesa.cs
namespace RestaurantePOO;
public class Mesa
{
    private int numeroMesa;
    private int quantidadePessoas;

    public Mesa(int numeroMesa)
    {
        this.numeroMesa = numeroMesa;
        this.quantidadePessoas = 0;
    }

    public int GetNumeroMesa()
    {
        return numeroMesa;
    }

    public int GetQuantidadePessoas()
    {
        return quantidadePessoas;
    }

    public void SetQuantidadePessoas(int quantidadePessoas)
    {
        if (quantidadePessoas > 0)
        {
            this.quantidadePessoas = quantidadePessoas;
        }
        else
        {
            throw new ArgumentException("Quantidade de pessoas deve ser maior que zero");
        }
    }
}