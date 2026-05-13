using System;
class Program
{
    public static void Main(string[] args)
    {
        string[] numeros = Console.ReadLine().Split(' ');
        int a = int.Parse(numeros[0]);
        int b = int.Parse(numeros[1]);
        int c = int.Parse(numeros[2]);
        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maior = maiorAB > c ? maiorAB : c;
        Console.WriteLine($"{maior} eh o maior");
    }
}