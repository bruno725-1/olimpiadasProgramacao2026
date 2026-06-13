using System;
class Program
{
    static void Main(string[] args)
    {
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            string[] valores = linha.Split(' ');
            int n = int.Parse(valores[0]);
            int r = int.Parse(valores[1]);
            if(n == r)
                Console.WriteLine("*");

            valores = Console.ReadLine().Split(' ');
            int[] voluntarios = PreencherVetor(n);
            int[] vr = ToIntArray(valores); // vetor para armazenar as placas dos mergulhadores que retornaram
            if (n - r > 0)
            {
                int[] vetor2 = new int[n - r];
                for (int i = 0; i < n; i++)
                {

                }
            }
        }
    }

    public static int[] ToIntArray(string[] dados)
    {
        int[] vetor = new int[dados.Length];
        for (int i = 0; i < dados.Length; i++)
            vetor[i] = int.Parse(dados[i]);

        return vetor;
    }

    public static int[] PreencherVetor(int comprimento)
    {
        int[] vetor = new int[comprimento];
        for (int i = 0; i < comprimento; i++)
            vetor[i] = i + 1;

        return vetor;
    }
}