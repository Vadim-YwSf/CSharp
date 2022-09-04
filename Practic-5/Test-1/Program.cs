int[] array = GetArray(10, 100, 1000);

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

void PrintArray(int[] array)
{
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine("");
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] %2 == 0)
{
    count = count + 1;
}
}

PrintArray(array);
Console.WriteLine($"Количество четных чисел = {count}");