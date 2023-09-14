﻿using System;

namespace Sistema_para_gestão_de_blocos
{
    class Program
    {
        private static readonly object meuBloco;

        static void Main(string[] args)
        {
            GestorBlocos gestor = new GestorBlocos();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Cadastrar Bloco");
                Console.WriteLine("2. Listar Blocos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarBloco(gestor);
                        break;

                    case "2":
                        Console.WriteLine("Lista de Blocos:");
                        var blocos = gestor.ListarBlocos();
                        foreach (var b in blocos)
                        {
                            Console.WriteLine(b);
                        }
                        break;
                 
                    case "3":
                        Console.WriteLine("Saindo do programa.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        private static void CalcularLucro(GestorBlocos gestor)
        {
            throw new NotImplementedException();
        }

        // Função para cadastrar um bloco com número, valor de compra e valor de venda
        static void CadastrarBloco(GestorBlocos gestor)
        {
            Console.Write("Número do Bloco: ");
            string numero = Console.ReadLine();

            Console.Write("Valor de Compra: ");
            double valorCompra = double.Parse(Console.ReadLine());

            Console.Write("Valor de Venda: ");
            double valorVenda = double.Parse(Console.ReadLine());

            Console.Write("Nome do Bloco: ");
            string nome = Console.ReadLine();

            Console.Write("Comprimento (mm): ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.Write("Largura (mm): ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Espessura (mm): ");
            double espessura = double.Parse(Console.ReadLine());

            Console.Write("Material: ");
            string material = Console.ReadLine();

            // Cria um objeto Bloco com os dados fornecidos pelo usuário
            Bloco bloco = new Bloco(nome, comprimento, largura, espessura, material);

            // Define as propriedades de número, valor de compra e valor de venda
            bloco.Numero = numero;
            bloco.ValorCompra = valorCompra;
            bloco.ValorVenda = valorVenda;
            double lucro  = bloco.CalcularLucro();
            Console.WriteLine($"Lucro de venda do bloco: {lucro}");


            // Adiciona o bloco à lista gerenciada pelo GestorBlocos
            gestor.AdicionarBloco(bloco);

            Console.WriteLine("Bloco cadastrado com sucesso!");
        }
    }
}
