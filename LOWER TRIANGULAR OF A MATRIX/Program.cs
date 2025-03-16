class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = i + j;
            }
        }
        Console.WriteLine("\nMatriz completa:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nTriangular inferior:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j <= i; j++) 
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

    




