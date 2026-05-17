using System;
class Program
{
    static void Main(string[] args)
    {
        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');
        double dif1 = double.Parse(p2[0]) - double.Parse(p1[0]);
        double dif2 = double.Parse(p2[1]) - double.Parse(p1[1]);
        double soma = Potencia(dif1) + Potencia(dif2);
        double distancia = Math.Sqrt(soma);
        Console.WriteLine($"{distancia:F4}");
    }

    public static double Potencia(double num) => num * num;
}