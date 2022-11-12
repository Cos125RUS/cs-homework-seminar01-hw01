// Написать программу вычисления функции Аккермана


int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else
        if (n == 0 && m > 0) return Ackermann(m - 1, 1);
        else return Ackermann(m - 1, Ackermann(m, n - 1));
}


Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ackermann ({m}, {n}) = {Ackermann(m, n)}");
