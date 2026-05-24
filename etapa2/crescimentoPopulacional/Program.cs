using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        for(int i = 0; i < t; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int pa = int.Parse(linha[0]);
            int pb = int.Parse(linha[1]);
            double g1 = double.Parse(linha[2], CultureInfo.InvariantCulture);
            double g2 = double.Parse(linha[3], CultureInfo.InvariantCulture);
            int j;
            for(j = 0; j <= 100 && pa <= pb; j++)
            {
                pa = pa + (int)Math.Floor(pa * g1 / 100);
                pb = pb + (int)Math.Floor(pb * g2 / 100);
            }
            if(j > 100)
                Console.WriteLine("Mais de 1 seculo.");
            else
                Console.WriteLine($"{j} anos.");
        }
    }
}