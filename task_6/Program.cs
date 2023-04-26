// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string third_num = Convert.ToString(number);

if (third_num.Length > 2)
{
    Console.WriteLine("Третья цифра числа " + number + " это " + third_num[2]);
}
else
    Console.WriteLine("Третьей цифры нет");
