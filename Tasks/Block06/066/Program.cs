// Показать натуральные числа от 1 до N, N задано

void Numbers(int n, int m)
{
    if (n == m)
    {
        System.Console.WriteLine(m);
    }
    else
    {
        System.Console.WriteLine(m);
        Numbers(n, m + 1);
    }
}


Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
Numbers(n, 1);