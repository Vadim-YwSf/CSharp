// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Metod2(int numb)
{
    int count = Convert.ToString(numb).Length;
    int avd = 0;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        avd = numb - numb % 10;
        sum = sum + (numb - avd);
        numb = numb / 10;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел числа {num} равна {Metod2(num)}!");