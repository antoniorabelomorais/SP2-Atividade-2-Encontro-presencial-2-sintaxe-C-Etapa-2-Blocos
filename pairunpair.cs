using System;

class Program
{
    static void Main()
    {
        int numero;
        int contarPares = 0;
        int contarImpares = 0;

        Console.WriteLine("=== Contagem de Pares e Ímpares ===");
        Console.WriteLine("Digite números (0 para parar):\n");

        while (true)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
                break;

            if (numero % 2 == 0)
                contarPares++;
            else
                contarImpares++;
        }

        Console.WriteLine($"\n=== RESULTADO ===");
        Console.WriteLine($"Números pares: {contarPares}");
        Console.WriteLine($"Números ímpares: {contarImpares}");
    }
}
