using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Verificador de Números Primos ===\n");
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 2)
        {
            Console.WriteLine($"\n❌ {numero} NÃO é primo (números primos começam em 2)");
            return;
        }

        int divisores = 0;
        int divisor = 1;

        while (divisor <= numero)
        {
            if (numero % divisor == 0)
                divisores++;
            divisor++;
        }

        Console.WriteLine($"\n=== RESULTADO ===");
        Console.WriteLine($"Número: {numero}");
        Console.WriteLine($"Divisores encontrados: {divisores}");

        if (divisores == 2)
            Console.WriteLine($"✅ {numero} É PRIMO");
        else
            Console.WriteLine($"❌ {numero} NÃO é primo");
    }
}
