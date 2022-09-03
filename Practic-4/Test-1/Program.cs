//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Metod1(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result*num1;
    }
    return result;
}

Console.WriteLine("Введите число A!");
int Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B!");
int Numb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {Num} в степени {Numb} равно {Metod1(Num, Numb)}!");