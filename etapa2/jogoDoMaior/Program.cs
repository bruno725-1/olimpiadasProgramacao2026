using System;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 0)
                break;

            int jogador1 = 0, jogador2 = 0;
            for(int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                int a = int.Parse(linha[0]);
                int b = int.Parse(linha[1]);
                if(a > b)
                    jogador1++;
                else if(b > a)
                    jogador2++;
            }
            Console.WriteLine($"{jogador1} {jogador2}");
        }
    }
}