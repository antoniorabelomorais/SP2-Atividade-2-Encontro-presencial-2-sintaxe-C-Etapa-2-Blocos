using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroCorreto = random.Next(1, 101); // 1 a 100
        int palpite;
        int tentativas = 0;

        Console.WriteLine("=== Jogo de Adivinhação ===");
        Console.WriteLine("Pensei em um número entre 1 e 100.\n");

        do
        {
            Console.Write("Qual é seu palpite? ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroCorreto)
                Console.WriteLine("❌ Seu palpite é MENOR que o número correto.\n");
            else if (palpite > numeroCorreto)
                Console.WriteLine("❌ Seu palpite é MAIOR que o número correto.\n");
            else
                Console.WriteLine($"\n✅ ACERTOU! Era {numeroCorreto}");

        } while (palpite != numeroCorreto);

        Console.WriteLine($"Você conseguiu em {tentativas} tentativa(s)!");
    }
}
