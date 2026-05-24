using System;
class Program
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine(Potencia(r));
    }

    public static double Potencia(int r)
    {
        double resultado = 3;
        if(r == 0) return 1;
        for(int i = 1; i < r; i++)
            resultado *= 3;

        return resultado;
    }
}