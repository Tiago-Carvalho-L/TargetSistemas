using System;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva uma palavra: ");
            string palavra = Console.ReadLine();
            int tamanhoPalavra = palavra.Length - 1;
            string palavraInvertida = "";

            for (int i = tamanhoPalavra; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }

            Console.WriteLine($"palavra invertida: {palavraInvertida}");
        }
    }
}
