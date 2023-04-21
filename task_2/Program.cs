// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите три числа:");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());
int max_number = number_1;
if (number_2 > max_number)
{
    max_number = number_2;
}
if(number_3 > max_number)
{
    max_number = number_3;
}
Console.WriteLine("Наибольшее число: " + max_number);
