Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 15;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double Number = Math.Round(array[i, j], 1);
            Console.Write(Number + " ");
        }
        Console.WriteLine();
    }
}

double[,] array = new double[m, n];

CreateArrayDouble(array);

PrintArray(array);