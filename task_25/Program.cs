// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int[,] arr = new int[4, 4];
int value = 1;
int top = 0, bottom = 3, left = 0, right = 3;

while (value <= 16)
{
    for (int i = left; i <= right; i++)
    {
        arr[top, i] = value++;
    }
    top++;

    for (int i = top; i <= bottom; i++)
    {
        arr[i, right] = value++;
    }
    right--;

    for (int i = right; i >= left; i--)
    {
        arr[bottom, i] = value++;
    }
    bottom--;

    for (int i = bottom; i >= top; i--)
    {
        arr[i, left] = value++;
    }
    left++;
}

Console.WriteLine("Спирально заполненный массив:");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0:00} ", arr[i, j]);
    }
    Console.WriteLine();
}
