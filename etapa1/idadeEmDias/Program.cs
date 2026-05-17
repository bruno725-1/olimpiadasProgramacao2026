using System;
class Program
{
    static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());
        int anos = 0, meses = 0, dias = 0;
        for(int i = 1; i <= idade; i++)
        {
            dias++;
            if(dias % 30 == 0)
            {
                meses++;
                dias = 0;
            }
            if(i % 365 == 0)
            {
                anos++;
                meses = 0;
                dias = 0;
            }
        }
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}