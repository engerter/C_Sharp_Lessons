// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int[] arr = GenerateRandomArray(10);
Console.Write("Массив заполненный случайными числами: ");
PrintArray(arr);
int sum = SumOddElements(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");

int[] GenerateRandomArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

int SumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
