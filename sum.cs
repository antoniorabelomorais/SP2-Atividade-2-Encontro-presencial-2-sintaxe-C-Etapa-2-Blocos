using System;

class Program
{
    static void Main()
    {
        double numero;
        double soma = 0;
        int quantidade = 0;

        Console.WriteLine("=== Soma de Números Positivos ===");
        Console.WriteLine("Digite números positivos (número negativo para parar):\n");

        while (true)
        {
            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero < 0)
                break;

            soma += numero; // Acumuladora
            quantidade++;
        }

        Console.WriteLine($"\n=== RESULTADO ===");
        Console.WriteLine($"Quantidade de números: {quantidade}");
        Console.WriteLine($"Soma total: {soma}");
        
        if (quantidade > 0)
            Console.WriteLine($"Média: {soma / quantidade:F2}");
    }
}
