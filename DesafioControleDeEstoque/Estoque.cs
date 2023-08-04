using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    public class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarItemAoEstoque()
        {
            Console.WriteLine("Digite os detalhes do item de estoque:");
            Console.Write("Lote: ");
            string lote = Console.ReadLine();

            Console.Write("Item: ");
            string item = Console.ReadLine();

            Console.Write("Data de Fabricação (formato: dd/mm/aaaa): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dataFabricacao))
            {
                Console.Write("Data de Vencimento (formato: dd/mm/aaaa): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dataVencimento))
                {
                    Produto novoProduto = new Produto(lote, item, dataFabricacao, dataVencimento);
                    produtos.Add(novoProduto);
                    Console.WriteLine("Item adicionado ao estoque com sucesso!");
                }
                else
                {
                    Console.WriteLine("Data de Vencimento inválida.");
                }
            }
            else
            {
                Console.WriteLine("Data de Fabricação inválida.");
            }
        }

        public void ExibirEstoque()
        {
            Console.WriteLine("Estoque atual:");
            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
        }
        public void ComprarProduto()
        {
            Console.WriteLine("Digite o nome (item) do produto que deseja comprar:");
            string item = Console.ReadLine();

            Produto produte = produtos.Find(prod => prod.Item.Equals(item, StringComparison.OrdinalIgnoreCase));
            if (produte == null)
            {
                Console.WriteLine("Produto não encontrado no estoque.");
                return;
            }

            Console.WriteLine("Produto encontrado:");
            Console.WriteLine(produte);
            Console.WriteLine("Deseja comprar este produto? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() == "S")
            {
                produtos.Remove(produte);
                Console.WriteLine("Produto comprado com sucesso!");
            }
        }
    }
}
