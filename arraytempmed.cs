using System;

class Program
{
    static void Main()
    {
        double[] temperaturas = new double[7];
        string[] dias = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };

        // Leitura das temperaturas
        Console.WriteLine("=== Registro de Temperaturas da Semana ===\n");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Temperatura de {dias[i]}: ");
            temperaturas[i] = double.Parse(Console.ReadLine());
        }

        // Cálculo da média
        double soma = 0;
        foreach (double temp in temperaturas)
        {
            soma += temp;
        }
        double media = soma / 7;

        // Exibição de dias acima da média
        Console.WriteLine($"\n=== RESULTADO ===");
        Console.WriteLine($"Média da semana: {media:F2}°C\n");
        Console.WriteLine("Dias com temperatura ACIMA da média:");

        foreach (int i in new int[7] { 0, 1, 2, 3, 4, 5, 6 })
        {
            if (temperaturas[i] > media)
                Console.WriteLine($"  {dias[i]}: {temperaturas[i]:F2}°C");
        }
    }
}
