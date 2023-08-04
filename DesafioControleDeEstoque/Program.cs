using ControleDeEstoque;
using System;
using System.Reflection.Metadata.Ecma335;


public class Program
{
    public static void Main()
    {
        Estoque estoque = new Estoque();

        while (true)
        {
            Console.WriteLine("\t\t\t\t## Desafio Sistema de Compra/ Estoque ##:");
            Console.WriteLine("1 - Adicionar item ao estoque");
            Console.WriteLine("2 - Comprar produto");
            Console.WriteLine("3 - Exibir estoque");
            Console.WriteLine("4 - Sair");

            Console.Write("\nEscolha uma opção: ");
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