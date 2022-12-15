// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите 1 число:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число:");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n)
    {
        Console.WriteLine(Sum(m, n));
    }
else
    {
        Console.WriteLine(Sum(n, m));
    }


int Sum(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return (end + Sum (start,--end));
}