using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el orden de la matriz (impar): ");
        int N = int.Parse(Console.ReadLine());

        if (N % 2 == 0)
        {
            Console.WriteLine("El orden de la matriz debe ser un número impar.");
            return;
        }

        int[,] matriz = new int[N, N];

        int valor = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = valor++;
            }
        }

        Console.WriteLine("\nMATRIZ COMPLETA:");
        ImprimirMatriz(matriz, N, true);

        Console.WriteLine("\nRELOJ DE ARENA:");
        ImprimirRelojDeArena(matriz, N);
    }

    static void ImprimirMatriz(int[,] matriz, int N, bool completa)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"{matriz[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    static void ImprimirRelojDeArena(int[,] matriz, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
               
                if (j >= i && j < N - i || j <= i && j >= N - i - 1)
                {
                    Console.Write($"{matriz[i, j],3} ");
                }
                else
                {
                    Console.Write("    "); 
                }
            }
            Console.WriteLine();
        }
    }
}



