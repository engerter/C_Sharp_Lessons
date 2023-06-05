// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int[,] arr = new int[3, 4];
Random random = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr[i, j] = random.Next(10);
    }
}

double[] averages = new double[4];

for (int j = 0; j < 4; j++)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += arr[i, j];
    }
    averages[j] = (double)sum / 3.0;
}

Console.WriteLine("Массив:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое каждого столбца:");

for (int j = 0; j < 4; j++)
{
    Console.WriteLine("Столбец " + j + ": " + Math.Round(averages[j], 1));
}
