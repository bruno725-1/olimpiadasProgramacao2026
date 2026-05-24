using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int numeroAlunos = int.Parse(linha[0]);
            int numeroSecreto = int.Parse(linha[1]);
            linha = Console.ReadLine().Split(' ');
            int[] palpites = ToIntArray(linha, numeroAlunos);
            int menorDistancia = int.MaxValue;
            int vencedor = 0;
            for(int j = 0; j < palpites.Length; j++)
            {
                int distancia = Math.Abs(palpites[j] - numeroSecreto);
                if(distancia < menorDistancia)
                {
                    menorDistancia = distancia;
                    vencedor = j + 1; // Posição começa em 1
                }
            }
            Console.WriteLine(vencedor);
        }
    }

    public static int[] ToIntArray(string[] dados, int tamanho)
    {
        int[] vetor = new int[tamanho];
        for(int i = 0; i < tamanho; i++)
            vetor[i] = int.Parse(dados[i]);

        return vetor;
    }
}