// Возведите число А в натуральную степень B используя цикл

int a = Random.Shared.Next(1,10);
Console.WriteLine("A = "+a);

int b = Random.Shared.Next(1,10);
Console.WriteLine("B = "+b);

int res = 1;

while (b > 0)
{
    res *= a;
    b--;
}

Console.WriteLine("A^B = "+res);