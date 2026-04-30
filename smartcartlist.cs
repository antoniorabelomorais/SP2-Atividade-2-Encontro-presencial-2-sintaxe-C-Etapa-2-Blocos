using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> produtos = new List<string>();

        Console.WriteLine("=== Lista de Compras ===");
        Console.WriteLine("Digite produtos (escreva 'fim' para parar):\n");

        while (true)
        {
            Console.Write("Produto: ");
            string produto = Console.ReadLine();

            if (produto.ToLower() == "fim")
                break;

            produtos.Add(produto);
        }

        // Ordenação alfabética
        produtos.Sort();

        // Filtragem: apenas produtos que começam com 'A' ou 'a'
        Console.WriteLine("\n=== Produtos que começam com 'A' (Alfabeticamente) ===\n");

        bool encontrouA = false;
        foreach (string prod in produtos)
        {
            if (prod.StartsWith("A") || prod.StartsWith("a"))
            {
                Console.WriteLine($"  ✓ {prod}");
                encontrouA = true;
            }
        }

        if (!encontrouA)
            Console.WriteLine("  Nenhum produto encontrado com a letra 'A'");

        Console.WriteLine($"\nTotal de produtos na lista: {produtos.Count}");
    }
}
