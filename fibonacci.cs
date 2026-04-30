using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sequência de Fibonacci ===\n");
        Console.Write("Quantos termos deseja visualizar? ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade <= 0)
        {
            Console.WriteLine("Digite um número maior que 0");
            return;
        }

        Console.WriteLine($"\nPrimeiros {quantidade} termos da sequência Fibonacci:\n");

        long numero1 = 0;
        long numero2 = 1;

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(numero1 + " ");

            // Próximo = soma dos dois anteriores
            long proxima = numero1 + numero2;
            numero1 = numero2;
            numero2 = proxima;
        }

        Console.WriteLine();
    }
}
