Console.WriteLine("Введите число");
string numb = Console.ReadLine();
if (numb.Length > 2)
{
    Console.WriteLine($"Третья цифра числа {numb} --> {numb[2]}");
}
else 
{
Console.WriteLine("Третьей цифры нет");
}