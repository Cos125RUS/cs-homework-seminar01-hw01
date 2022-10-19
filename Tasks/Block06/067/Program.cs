// Показать натуральные числа от N до 1, N задано

int Numbers(int n)
{
    if (n == 1) {
        Console.WriteLine(1);
        return 1;}
    else
    {
        Console.WriteLine(n);
        return Numbers(n - 1);
    }
}

Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
Numbers(n);