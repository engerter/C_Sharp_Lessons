// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
int i = 1;
bool no_numbers = true;
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " +number+ ":");
while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + " ");
        no_numbers = false;
    }
    i++;
}

if (no_numbers)
{
    Console.WriteLine("Нет чётных чисел!");
}
