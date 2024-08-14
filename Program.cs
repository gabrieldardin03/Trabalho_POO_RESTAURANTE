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
                Console.WriteLine("1. Criar restaurante");
                Console.WriteLine("2. Criar prato");
                Console.WriteLine("3. Adicionar prato ao restaurante");
                Console.WriteLine("4. Listar restaurantes");
                Console.WriteLine("5. Listar pratos de um restaurante");
                Console.WriteLine("6. Processar pedido");
                Console.WriteLine("7. Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

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
            string nome = Console.ReadLine();
            Console.Write("Endereço do restaurante: ");
            string endereco = Console.ReadLine();
            Console.Write("Telefone do restaurante: ");
            string telefone = Console.ReadLine();

            Restaurante restaurante = new Restaurante(nome, endereco, telefone);
            restaurantes.Add(restaurante);
            Console.WriteLine("Restaurante criado com sucesso!");
        }

        static void CriarPrato()
        {
            Console.Write("Nome do prato: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do prato: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.Write("É vegetariano? (s/n): ");
            bool vegetariano = Console.ReadLine().ToLower() == "s";

            Prato prato = new Prato(nome, preco, vegetariano);
            Console.WriteLine("Prato criado com sucesso!");
        }

        static void AdicionarPratoAoRestaurante(List<Restaurante> restaurantes)
        {
            Console.Write("Selecione o restaurante: ");
            int indiceRestaurante = int.Parse(Console.ReadLine());
            Restaurante restaurante = restaurantes[indiceRestaurante - 1];

            Console.Write("Selecione o prato: ");
            // TODO: implementar lista de pratos
            Prato prato = null;

            restaurante.AdicionarPrato(prato);
            Console.WriteLine("Prato adicionado com sucesso!");
        }

        static void ListarRestaurantes(List<Restaurante> restaurantes)
        {
            Console.WriteLine("Restaurantes:");
            for (int i = 0; i < restaurantes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {restaurantes[i].Nome}");
            }
        }

        static void ListarPratosDeUmRestaurante(List<Restaurante> restaurantes)
        {
            Console.Write("Selecione o restaurante: ");
            int indiceRestaurante = int.Parse(Console.ReadLine());
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
    int indiceRestaurante = int.Parse(Console.ReadLine());
    Restaurante restaurante = restaurantes[indiceRestaurante - 1];

    Console.WriteLine("Pratos disponíveis:");
    for (int i = 0; i < restaurante.Cardapio.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {restaurante.Cardapio[i].Nome} - R$ {restaurante.Cardapio[i].ObterPreco():F2}");
    }

    Console.Write("Selecione o prato: ");
    int indicePrato = int.Parse(Console.ReadLine());
    Prato pratoSelecionado = restaurante.Cardapio[indicePrato - 1];

    Pedido pedido = new Pedido(restaurante.Nome);
    pedido.AdicionarPrato(pratoSelecionado);
    Console.WriteLine("Pedido criado com sucesso!");
}
}
}