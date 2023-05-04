// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num_len = number.Length;

if (num_len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine(number+" (ДА) - является палиндромом");
    }
    else
    {
        Console.WriteLine(number+" (НЕТ) - не является палиндромом");
    }
}
else
{
    Console.WriteLine(number+ " не является пятизначным");
}
