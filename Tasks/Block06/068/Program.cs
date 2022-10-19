// Показать натуральные числа от M до N, N и M заданы


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


int n, m;
do
{
    Console.Write("N = ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write("M = ");
    m = Convert.ToInt32(Console.ReadLine());
    if (n < m) System.Console.WriteLine("Error! N < M. Try again.");
} while (n < m);

System.Console.WriteLine();
Numbers(n, m);
