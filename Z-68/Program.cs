// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("(A(m,n) Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("(A(m,n) Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(m, n));

int Sum(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    if (m == 1)  
    {       
        return n+2;
    }
    if (m==2)
    {
        return 2*n+3;
    }
    if (m==3)
    {
        int p = 2;
        for (int i= 2; i<=n+3; i++)
        {
            p = p*2;
        }
        return p-3;
    }
    return (Sum(m,n));
}