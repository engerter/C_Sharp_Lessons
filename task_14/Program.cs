// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Random rnd = new Random();
int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(100, 1000);
}

Console.Write("Массив случайных трехзначных чисел: ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

int count = CountEvenNumbers(numbers);
Console.WriteLine($"Количество четных чисел в массиве: {count}");

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
