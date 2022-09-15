//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMatrixx, int[,] secondMatrixx, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrixx.GetLength(1); k++)
            {
                sum += firstMatrixx[i, k] * secondMatrixx[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.Write("Введите количество строк 1-й матрицы: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
int column = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов 2-й матрицы: ");
int columns = int.Parse(Console.ReadLine());

int[,] firstMatrix = GetArray(rows, column, 0, 10);
PrintArray(firstMatrix);

Console.WriteLine();

int[,] secondMatrix = GetArray(column, columns, 0, 10);
PrintArray(secondMatrix);

int[,] resultMatrix = new int[rows, columns];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);
