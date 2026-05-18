using System;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int h1 = int.Parse(linha[0]);
            int m1 = int.Parse(linha[1]);
            int h2 = int.Parse(linha[2]);
            int m2 = int.Parse(linha[3]);
            if(h1 == 0 && m1 == 0 && h2 == 0 && m2 == 0)
                break;

            int atual = h1 * 60 + m1;
            int alarme = h2 * 60 + m2;
            if(alarme <= atual)
                alarme += 24 * 60;

            int total = alarme - atual;
            Console.WriteLine(total);
        }
    }
}