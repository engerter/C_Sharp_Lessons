// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int second_num = (number % 100 - number % 10) / 10;
    Console.WriteLine("Вторая цифра числа "+number+" это "+second_num);
}
else
    System.Console.WriteLine("Это число не трехзначное");
