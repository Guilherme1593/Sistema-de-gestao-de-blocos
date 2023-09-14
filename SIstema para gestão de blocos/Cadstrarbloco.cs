using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_gestão_de_blocos
{
    internal class Cadastrarbloco
    {
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

            // Adiciona o bloco à lista gerenciada pelo GestorBlocos
            gestor.AdicionarBloco(bloco);

            Console.WriteLine("Bloco cadastrado com sucesso!");
        }
    }
}
