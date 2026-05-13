using System;
class Program
{
    public static void Main(string[] args)
    {
        string[] peca1 = Console.ReadLine().Split(' ');
        string[] peca2 = Console.ReadLine().Split(' ');
        double valorPeca1 = CalcularValor(peca1);
        double valorPeca2 = CalcularValor(peca2);
        double precoTotal = valorPeca1 + valorPeca2;
        Console.WriteLine($"VALOR A PAGAR: R$ {precoTotal:F2}");
    }

    public static double CalcularValor(string[] dados)
    {
        int quantidade = int.Parse(dados[1]);
        double valorUnitario = double.Parse(dados[2]);
        double preco = valorUnitario * quantidade;
        return preco;
    }
}