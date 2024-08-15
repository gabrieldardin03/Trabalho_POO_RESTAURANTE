using System;
using System.Collections.Generic;

namespace RestaurantePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Restaurante> restaurantes = new List<Restaurante>();

            while (true)
            {
                Console.WriteLine("\n 1. Criar restaurante");
                Console.WriteLine("2. Criar prato");
                Console.WriteLine("3. Adicionar prato ao restaurante");
                Console.WriteLine("4. Listar restaurantes");
                Console.WriteLine("5. Listar pratos de um restaurante");
                Console.WriteLine("6. Processar pedido");
                Console.WriteLine("7. Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
              
                switch (opcao)
                {
                    case 1:
                        CriarRestaurante(restaurantes);
                        break;
                    case 2:
                        CriarPrato();
                        break;
                    case 3:
                        AdicionarPratoAoRestaurante(restaurantes);
                        break;
                    case 4:
                        ListarRestaurantes(restaurantes);
                        break;
                    case 5:
                        ListarPratosDeUmRestaurante(restaurantes);
                        break;
                    case 6:
                        ProcessarPedido(restaurantes);
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void CriarRestaurante(List<Restaurante> restaurantes)
{
    Console.Write("Nome do restaurante: ");
    string nome = Convert.ToString(System.Console.ReadLine());
    Console.Write("Endereço do restaurante: ");
    string endereco = Convert.ToString(System.Console.ReadLine());
    Console.Write("Telefone do restaurante: ");
    string telefone = Convert.ToString(System.Console.ReadLine());
//fiz um if para se o usuario adinar valores nulos e notifique que precisa preencher todos os campos

    if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(endereco) && !string.IsNullOrEmpty(telefone))
    {
        Restaurante restaurante = new Restaurante(nome, endereco, telefone);
        restaurantes.Add(restaurante);
        Console.WriteLine("Restaurante criado com sucesso!");
    }
    else
    {
        Console.WriteLine("Preencha todos os campos para criar o restaurante.");
    }
}

       static void CriarPrato()
{
    Console.Write("Nome do prato: ");
    string nome = Console.ReadLine();
    Console.Write("Preço do prato: ");
    string precoStr = Console.ReadLine();
    decimal preco;
    Console.Write("É vegetariano? (s/n): ");
    string vegetarianoStr = Console.ReadLine();

    if (!string.IsNullOrEmpty(nome) && decimal.TryParse(precoStr, out preco) && (vegetarianoStr.ToLower() == "s" || vegetarianoStr.ToLower() == "n"))
    {
        bool vegetariano = vegetarianoStr.ToLower() == "s";
        Prato prato = new Prato(nome, preco, vegetariano);
        pratos.Add(prato); // adiciona o prato à lista de pratos
        Console.WriteLine("Prato criado com sucesso!");
    }
    else
    {
        Console.WriteLine("Preencha todos os campos corretamente para criar o prato.");
    }
}
  static void AdicionarPratoAoRestaurante(List<Restaurante> restaurantes)
{
    Console.Write("Selecione o restaurante: ");
    string indiceRestauranteStr = Console.ReadLine();
    if (string.IsNullOrEmpty(indiceRestauranteStr))
    {
        Console.WriteLine("Selecione um restaurante válido.");
        return;
    }
    int indiceRestauranteInt = int.Parse(indiceRestauranteStr) - 1;
    if (indiceRestauranteInt < 0 || indiceRestauranteInt >= restaurantes.Count)
    {
        Console.WriteLine("Selecione um restaurante válido.");
        return;
    }
    Restaurante restaurante = restaurantes[indiceRestauranteInt];

    Console.WriteLine("Pratos");
    for (int i = 0; i < pratos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {pratos[i].Nome}");
    }

    Console.Write("Selecione o prato: ");
    string indicePratoStr = Console.ReadLine();
    if (string.IsNullOrEmpty(indicePratoStr))
    {
        Console.WriteLine("Selecione um prato válido.");
        return;
    }
    int indicePratoInt = int.Parse(indicePratoStr) - 1;
    if (indicePratoInt < 0 || indicePratoInt >= pratos.Count)
    {
        Console.WriteLine("Selecione um prato válido.");
        return;
    }
    Prato prato = pratos[indicePratoInt];

    restaurante.AdicionarPrato(prato);
    Console.WriteLine("Prato adicionado com sucesso!");
}
static void ListarRestaurantes(List<Restaurante> restaurantes)
{
    Console.WriteLine("Restaurantes");
    for (int i = 0; i < restaurantes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {restaurantes[i].Nome}");
    }
}

        static void ListarPratosDeUmRestaurante(List<Restaurante> restaurantes)
        {
            Console.Write("Selecione o restaurante: ");
               int indiceRestaurante = Convert.ToInt32(System.Console.ReadLine());
            Restaurante restaurante = restaurantes[indiceRestaurante - 1];

            Console.WriteLine("Pratos:");
            foreach (var prato in restaurante.Cardapio)
            {
                Console.WriteLine($"{prato.Nome} - R$ {prato.ObterPreco():F2}");
            }
        }

        static List<Prato> pratos = new List<Prato>(); // lista de pratos criados

static void ProcessarPedido(List<Restaurante> restaurantes)
{
    Console.Write("Selecione o restaurante: ");
     int indiceRestaurante = Convert.ToInt32(System.Console.ReadLine());
    Restaurante restaurante = restaurantes[indiceRestaurante - 1];

    Console.WriteLine("Pratos disponíveis:");
    for (int i = 0; i < restaurante.Cardapio.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {restaurante.Cardapio[i].Nome} - R$ {restaurante.Cardapio[i].ObterPreco():F2}");
    }

    Console.Write("Selecione o prato: ");
    int indicePrato = Convert.ToInt32(System.Console.ReadLine());
    Prato pratoSelecionado = restaurante.Cardapio[indicePrato - 1];

    Pedido pedido = new Pedido(restaurante.Nome);
    pedido.AdicionarPrato(pratoSelecionado);
    Console.WriteLine("Pedido criado com sucesso!");
}
}//            int indiceRestaurante = Convert.ToInt32(System.Console.ReadLine()); fazer nos demais
}