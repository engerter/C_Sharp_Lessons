// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.WriteLine("Введите значение M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine());

int sum = Sum(M, N);

Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N, sum);

int Sum(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return Sum(M, N - 1) + N;
    }
}
