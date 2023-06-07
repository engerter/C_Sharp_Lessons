// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];

Random random = new Random();

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = random.Next(10);
    }
}

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = random.Next(10);
    }
}

Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);

Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);

int[,] resultMatrix = MultiplyMatrix(matrix1, matrix2);

Console.WriteLine("Произведение двух матриц:");
PrintMatrix(resultMatrix);

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[2, 2];

    result[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
    result[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
    result[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
    result[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];

    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0}\t", matrix[i, j]);
        }

        Console.WriteLine();
    }
}
