// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

Console.Clear();

int m = 3;
int n = 4;

double[,] arr = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
