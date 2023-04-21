// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2)
{
    Console.WriteLine("Первое число больше чем второе!");
}
else
{
    Console.WriteLine("Второе число больше чем первое!");
}
