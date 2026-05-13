using System;
class Program
{
    static void Main(string[] args)
    {
        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());
        double consumo = distancia / combustivel;
        Console.WriteLine($"{consumo:F3} km/l");
    }
}