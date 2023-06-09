// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);

void PrintNumbers(int num)
{
    int minValue = 1;

    if (num < minValue) return;

    Console.Write(num + " ");

    PrintNumbers(num - 1);
}
