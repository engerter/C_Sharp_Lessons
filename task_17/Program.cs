// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int count = 0;
Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

for (int i = 1; i <= m; i++)
{
    Console.Write($"Введите число {i}: ");
    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше нуля: {count}");
