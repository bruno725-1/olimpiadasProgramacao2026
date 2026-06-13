using System;
class Program
{
    static void Main(string[] args)
    {
        string linha;
        while ((linha = Console.ReadLine()) != "*")
        {
            string[] palavras = linha.Split(' ');
            char[] primeiras = new char[palavras.Length];
            // Converter tudo para minúscula pra facilitar
            for(int i = 0; i < palavras.Length; i++)
            {
                char prim = palavras[i][0];
                if(char.IsUpper(prim))
                    prim = char.ToLower(prim);
                primeiras[i] = prim;
            }
            bool ehTaltograma = true;
            char primeira = primeiras[0];
            for(int i = 0; i < palavras.Length && ehTaltograma; i++)
            {
                if(primeiras[i] != primeira)
                    ehTaltograma = false;
            }
            if(ehTaltograma)
                Console.WriteLine("Y");
            else
                Console.WriteLine("N");
        }
    }
}