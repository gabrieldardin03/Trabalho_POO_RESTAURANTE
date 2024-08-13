// Prato.cs
using System;

public class Prato
{
    // Atributos privados para armazenar informações do prato
    private string nome;
    private decimal preco;
    private bool vegetariano;

    // Construtor para inicializar os atributos
    public Prato(string nome, decimal preco, bool vegetariano)
    {
        this.nome = nome;
        this.preco = preco;
        this.vegetariano = vegetariano;
    }

    // Métodos getters e setters para acessar e modificar os atributos
    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public decimal GetPreco()
    {
        return preco;
    }

    public void SetPreco(decimal preco)
    {
        this.preco = preco;
    }

    public bool GetVegetariano()
    {
        return vegetariano;
    }

    public void SetVegetariano(bool vegetariano)
    {
        this.vegetariano = vegetariano;
    }

    // Método para retornar uma string com as informações do prato
    //F2 foi utilizado para que fique apenas dois numeros após a virgula ex 2.50 R$
    public string GetPratoString()
    {
        return $"Prato: {nome}, Preço: R$ {preco:F2}, Vegetariano: {(vegetariano ? "Sim" : "Não")}";
    }
}