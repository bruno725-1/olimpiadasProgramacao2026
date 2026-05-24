using System;
class Program
{
    static void Main(string[] args)
    {
        // Armazenar todos os valores de notas e moedas. Para evitar problemas com ponto flutuante, utilizaremos todos os valores em centavos
        int[] valores = {10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1};
        decimal n = decimal.Parse(Console.ReadLine());
        decimal valorCentavos = Math.Round(n * 100m, 0, MidpointRounding.AwayFromZero);
        Console.WriteLine("NOTAS:");
        for(int i = 0; i < 6; i++)
        {
            int qtd = (int)valorCentavos / valores[i];
            valorCentavos = valorCentavos % valores[i];
            Console.WriteLine($"{qtd} nota(s) de R$ {valores[i] / 100.0:0.00}");
        }
        Console.WriteLine("MOEDAS:");
        for(int i = 6; i < valores.Length; i++)
        {
            int qtd = (int)valorCentavos / valores[i];
            valorCentavos = valorCentavos % valores[i];
            Console.WriteLine($"{qtd} moeda(s) de R$ {valores[i] / 100.0:0.00}");
        }
    }
}