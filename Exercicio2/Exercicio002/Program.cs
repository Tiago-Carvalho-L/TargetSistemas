using System;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacci = new List<int>();

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int resultado = 0;
            int i = 0;

            while (resultado <= numero)
            {
                fibonacci.Add(a);

                int aux = b;
                b = a;
                a = aux + b;

                resultado = a;
            }

            Console.WriteLine();
            if (fibonacci.Contains(numero)){
                Console.WriteLine($"O número {numero} PERTENCE a sequência Fibonacci");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO PERTENCE a sequência Fibonacci");
            }
            Console.WriteLine();
        }
    }
}
