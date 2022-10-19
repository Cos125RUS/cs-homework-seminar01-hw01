// Найти сумму элементов от M до N, N и M заданы

int sum = 0;

int Numbers(int n, int m)
{
    if (n < m)
    {
        return sum;
    }
    else
    {
        sum += m;
        Numbers(n, m + 1);
    }
    return sum;
}

(int, int) Interval()
{
    Console.Write("N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("M = ");
    int m = Convert.ToInt32(Console.ReadLine());

    if (n < m)
    {
        int s = n;
        n = m;
        m = s;
    }
    return (n, m);
}

(int n, int m) = Interval();
sum = Numbers(n, m);
System.Console.WriteLine("Sum = " + sum);