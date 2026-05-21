using System;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string linha = Console.ReadLine();
            if(int.TryParse(linha, out int resultado))
            {
                if(resultado == 0)
                    break;
            }

            Console.WriteLine(Fatorial(linha.Length));
        }
    }

    public static double Fatorial(int x)
    {
        if(x == 1) return 1;
        return x * Fatorial(x - 1);
    }
}