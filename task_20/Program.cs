// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] arr = new int[3, 4];
Random random = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10);
    }
}

Console.WriteLine("Массив:");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите значение элемента:");
int searchValue = int.Parse(Console.ReadLine());
bool elementFound = false;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (arr[i, j] == searchValue)
        {
            Console.WriteLine($"Позиция элемента: [{i}, {j}]");
            elementFound = true;
        }
    }
}

if (!elementFound)
{
    Console.WriteLine("Такого числа в массиве нет.");
}
