using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int k = int.Parse(Console.ReadLine());
            if(k == 0)
                break;

            string[] linha = Console.ReadLine().Split(' ');
            // armazenar as coordenadas do ponto divisor
            int leste_oeste = int.Parse(linha[0]);
            int norte_sul = int.Parse(linha[1]);
            for(int i = 0; i < k; i++)
            {
                linha = Console.ReadLine().Split(' ');
                int x = int.Parse(linha[0]); // Coordenadas leste-oeste da residência
                int y = int.Parse(linha[1]); // Coordenadas norte-sul da residência
                if(x < leste_oeste && y < norte_sul)
                    Console.WriteLine("SO");
                else if(x < leste_oeste && y > norte_sul)
                    Console.WriteLine("NO");
                else if(x > leste_oeste && y < norte_sul)
                    Console.WriteLine("SE");
                else if(x > leste_oeste && y > norte_sul)
                    Console.WriteLine("NE");
                else
                    Console.WriteLine("divisa");
            }
        }
    }
}