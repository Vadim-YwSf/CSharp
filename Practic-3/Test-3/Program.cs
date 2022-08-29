Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
string result = "";

for ( int i = 1; i <= N; i++)
{
    double res = Math.Pow(i, 3);
    result = result + res + " | ";
}

Console.WriteLine(result);