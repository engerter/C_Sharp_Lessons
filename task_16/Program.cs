// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Random rnd = new Random();
double[] arr = new double[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(rnd.NextDouble() * 20 - 10, 2);
}

Console.Write("Массив вещественных чисел: ");
PrintArray(arr);

double min = FindMin(arr);
double max = FindMax(arr);
double diff = Math.Round(max - min, 2);

Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}
