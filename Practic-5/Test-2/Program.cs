int[] array = GetArray(10, -10, 10);

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

int nechetsum = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    nechetsum = nechetsum + array[i];
}

PrintArray(array);
Console.WriteLine($"Сумма чисел на нечетных позициях = {nechetsum}");