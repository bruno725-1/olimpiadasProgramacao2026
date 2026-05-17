using System;
class Program
{
    static void Main(string[] args)
    {
        int tempo = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());
        int distancia = tempo * velocidadeMedia;
        double combustivel = (double)distancia / 12;
        Console.WriteLine($"{combustivel:F3}");
    }
}