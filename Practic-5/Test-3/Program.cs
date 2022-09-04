int[] array = GetArray(10, 1, 100);

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

int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
   if (max < array[i])
    {
      max = array[i];
    }
        if (min > array[i])
         {
             min = array[i];
         }
}

int result = max - min;
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {result}");