// Написать программу возведения числа А в целую стень B

int Exponentiation(int a, int b)
{
    if (b == 1) return a;
    else
        return a * Exponentiation(a, b - 1);
}

Console.Write("A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A^B = " + Exponentiation(a, b));