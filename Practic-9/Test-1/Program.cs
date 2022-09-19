//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

// if (n > m)
//     for (int i = m; i <= n; i++)
//         Console.Write($" {i}");
// else
//     for (int i = n; i <= m; i++)
//         Console.Write($" {i}");

int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

string PrintNumbers(int start, int end)
{
if (start == end) return start.ToString();
return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(m, n));