//Вариант 1
Console.Write("Введите числа(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов > 0: {count}");

//Вариант 2
// Console.Write($"Введи число М(количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[m];

// void InputNumbers(int m)
// {
//     for (int i = 0; i < m; i++)
//     {
//         Console.Write($"Введи {i + 1} число: ");
//         numbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// int Compar(int[] numbers)
// {
//     int count = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 0)
//             count += 1;
//     }
//     return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Кол-во элементов > 0: {Compar(numbers)} ");