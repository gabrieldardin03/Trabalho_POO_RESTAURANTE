// PedidoPresencial.cs
using System;
public class PedidoPresencial : Pedido
{
    private int mesa ;
    private int quantidadePessoas;

    public PedidoPresencial(string numeroPedido, bool comerNoRestaurante)
        : base(numeroPedido)
    {
        if (comerNoRestaurante)
        {
            Console.Write("Informe o número da mesa: ");
            int numeroMesa = int.Parse(Console.ReadLine());
            mesa = new mesa(numeroMesa);
            Console.Write("Informe a quantidade de pessoas sentadas na mesa: ");
            quantidadePessoas = int.Parse(Console.ReadLine());
        }
        else
        {
            mesa = null;
            quantidadePessoas = 0;
        }
    }

    public Mesa GetMesa()
    {
        return mesa;
    }

    public int GetQuantidadePessoas()
    {
        return quantidadePessoas;
    }

    public override decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (Prato prato in GetPratos())
        {
            total += prato.GetPreco();
        }
        return total;
    }

    public string GetPedidoPresencialString()
    {
        if (mesa != null)
        {
            return $"Pedido Presencial {GetNumeroPedido()}: Mesa {mesa.GetNumeroMesa()}, Quantidade de pessoas: {quantidadePessoas}, Total: R$ {CalcularTotal():F2}";
        }
        else
        {
            return $"Pedido Presencial {GetNumeroPedido()}: Para levar, Total: R$ {CalcularTotal():F2}";
        }
    }
    
}