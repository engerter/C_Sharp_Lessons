// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число, обозначающее день недели:");
int day_num = Convert.ToInt32(Console.ReadLine());

if (day_num == 6 || day_num == 7)
{
    Console.WriteLine("(ДА) Выходной день");
}
else if (day_num < 1 || day_num > 7)
{
    Console.WriteLine("Это не день недели!");
}
else Console.WriteLine("(НЕТ) Рабочий день");
