using System;
class Program
{
    public static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double media = (a * 2 + b * 3 + c * 5) / (2 + 3 + 5);
        Console.WriteLine($"MEDIA = {media:F1}");
    }
}