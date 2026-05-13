using System;
class Program
{
    public static void Main(string[] args)
    {
        int numeroFuncionario = int.Parse(Console.ReadLine());
        int horasTrabalhadas = int.Parse(Console.ReadLine());
        double valorHora = double.Parse(Console.ReadLine());
        double salario = valorHora * horasTrabalhadas;
        Console.WriteLine($"NUMBER = {numeroFuncionario}");
        Console.WriteLine($"SALARY = U$ {salario:F2}");
    }
}