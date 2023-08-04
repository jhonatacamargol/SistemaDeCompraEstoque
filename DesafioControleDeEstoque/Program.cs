using ControleDeEstoque;
using System;
using System.Reflection.Metadata.Ecma335;

/*Console.WriteLine("\t\t\t\t## Sistema de Estoque ##\n");
Console.WriteLine("Digite a opção desejada:\n\nOPÇÃO 1 = Adicionar Produto ao Estoque \t\t OPÇÃO 2 = Comprar Produto");

int opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 0 || opcao >2)
{
    Console.WriteLine("Opção Inválida Tente Novamente.");
    
}



Console.WriteLine("Digite o Lote:\n");
int loteAdcionado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Item:\n");
var itemAdcionado = Console.ReadLine();

Console.WriteLine("Digite a Data de Fabricação:\n");
int dataFabAdcionado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a Data de Vencimento:\n");
int dataVencAdcionado = Convert.ToInt32(Console.ReadLine());

*/

public class Program
{
    public static void Main()
    {
        Estoque estoque = new Estoque();

        while (true)
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar item ao estoque");
            Console.WriteLine("2 - Comprar produto");
            Console.WriteLine("3 - Exibir estoque");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    estoque.AdicionarItemAoEstoque();
                    break;
                case "2":
                    estoque.ComprarProduto();
                    break;
                case "3":
                    estoque.ExibirEstoque();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}