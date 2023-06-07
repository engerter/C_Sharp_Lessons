// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] arr = new int[3, 4];
Random rand = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr[i, j] = rand.Next(10);
    }
}

Console.WriteLine("Исходный массив:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = j + 1; k < 4; k++)
        {
            if (arr[i, k] > arr[i, j])
            {
                int temp = arr[i, j];
                arr[i, j] = arr[i, k];
                arr[i, k] = temp;
            }
        }
    }
}

Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
