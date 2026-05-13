using System;
class Program
{
    public static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        double fixo = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());
        double bonus = vendas * 0.15;
        double salario = fixo + bonus;
        Console.WriteLine($"TOTAL = R$ {salario:F2}");
    }
}