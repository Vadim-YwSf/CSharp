Console.WriteLine("Введите число А");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
double b = double.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("A больше B");
}
else if (a==b)
{
    Console.WriteLine("A равно B");
}
else
{
    Console.WriteLine("B больше A");
}