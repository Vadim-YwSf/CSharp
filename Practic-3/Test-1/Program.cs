Console.WriteLine("Введите 5-ти значное число!");
int num = Convert.ToInt32(Console.ReadLine());
String Number = Convert.ToString(num);

if (Number.Length > 5 | Number.Length < 5)
{
    Console.WriteLine("Введите правильное число!");
}
else if (Number[0] == Number[4] && Number[1] == Number[3])
{
    Console.WriteLine($"Ваше число {Number} - палиндром");
}
else
{
   Console.WriteLine($"Ваше число {Number} - Не палиндром");
}