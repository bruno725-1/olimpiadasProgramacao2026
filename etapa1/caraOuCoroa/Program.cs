using System;
class Program
{
    static void Main(string[] args)
    {
        int n;
        while((n = int.Parse(Console.ReadLine())) != 0)
        {
            string[] resultados = Console.ReadLine().Split(' ');
            int joao = 0, maria = 0; // Variáveis para armazenar o número de vezes que cada um ganhou
            for(int i = 0; i < n; i++)
            {
                if((int.Parse(resultados[i])) == 0)
                    maria++;
                else
                    joao++;
            }
            Console.WriteLine($"Mary won {maria} times and John won {joao} times");
        }
    }
}