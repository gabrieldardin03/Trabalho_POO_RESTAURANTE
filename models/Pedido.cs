// Pedido.cs
using System;

public abstract class Pedido
{
    // Atributos privados para armazenar informações do pedido
    private string numeroPedido;
    private List<Prato> pratos;

    // Construtor para inicializar os atributos
    public Pedido(string numeroPedido)
    {
        this.numeroPedido = numeroPedido;
        pratos = new List<Prato>();
    }

    // Métodos getters e setters para acessar e modificar os atributos
    public string GetNumeroPedido()
    {
        return numeroPedido;
    }

    public void SetNumeroPedido(string numeroPedido)
    {
        this.numeroPedido = numeroPedido;
    }

    public List<Prato> GetPratos()
    {
        return pratos;
    }

    public void AdicionarPrato(Prato prato)
    {
        pratos.Add(prato);
    }

    // Método abstrato para calcular o total do pedido
    public abstract decimal CalcularTotal();

    // Método para retornar o total do pedido como string
    public string GetTotalString()
    {
        return "Total do pedido: R$ " + CalcularTotal().ToString("F2");
    }
}