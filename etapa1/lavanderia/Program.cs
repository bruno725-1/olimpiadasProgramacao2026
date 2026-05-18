using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] linha = Console.ReadLine().Split(' ');
        int la = int.Parse(linha[0]);
        int lb = int.Parse(linha[1]);
        linha = Console.ReadLine().Split(' ');
        int sa = int.Parse(linha[0]);
        int sb = int.Parse(linha[1]);
        if(n >= la && n <= lb && n >= sa && n <= sb)
            Console.WriteLine("possivel");
        else
            Console.WriteLine("impossivel");
    }
}