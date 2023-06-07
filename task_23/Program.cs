// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] matrix = new int[4, 4];
Random random = new Random();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = random.Next(10);
    }
}

int minSum = int.MaxValue;
int minSumIndex = -1;

for (int i = 0; i < 4; i++)
{
    int rowSum = 0;
    for (int j = 0; j < 4; j++)
    {
        rowSum += matrix[i, j];
    }
    if (rowSum < minSum)
    {
        minSum = rowSum;
        minSumIndex = i;
    }
}

Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minSumIndex + 1));
Console.WriteLine("Сумма элементов в этой строке: " + minSum);
Console.WriteLine("Матрица для проверки:");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
