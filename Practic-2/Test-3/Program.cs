Console.WriteLine("Введите цифру дня недели (от 1 до 7)");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if (day < 1 || day > 7)
{
    Console.WriteLine("Это не день недели");
}
else 
{
    Console.WriteLine("Этот день не выходной");
}