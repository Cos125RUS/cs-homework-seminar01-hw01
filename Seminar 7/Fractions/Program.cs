// 1. Описать представление обыкновенной дроби
//   1/4  11/22  14/21

// 2. Описать логику сокращения дроби
//   1/4 -> 1/4   11/22 -> 1/2  14/21 -> 1/3

// 3. Продумать над тем, как хранить целую часть
//       1
//    5 --- 
//       3

// 4. Описать логику сложения двух дробей
// 5. Логика описывается методами

// ---------------------------------------------------

(int, int) Numbers(string num)
{
    var pos = num.IndexOf('/');
    int num1 = Convert.ToInt32(num.Substring(0, pos));
    int num2 = Convert.ToInt32(num.Substring(pos + 1));
    return (num1, num2);
}

(int, int) Dividers(int n1, int n2)
{
    int d = 1;
    for (int i = n1; i > 0; i--)
    {
        if (n1 % i == 0 && n2 % i == 0)
        {
            d = i;
            i = 0;
        }
    }
    n1 /= d;
    n2 /= d;
    return (n1, n2);
}

(int, int, int) Fraction()
{
    Console.Write("Enter the fraction   ");
    string num = Console.ReadLine();

    (int n1, int n2) = Numbers(num);
    (n1, n2) = Dividers(n1, n2);

    int whole = 0;
    if (n1 >= n2)
    {
        whole = n1 / n2;
        n1 -= whole * n2;

        Console.Write(whole);
    }

    Console.WriteLine($" [{n1}/{n2}]");
    return (whole, n1, n2);
}

(int, int) Addition(int n1, int d1, int n2, int d2)
{
    int min;
    if (d1 < d2) min = d1;
    else min = d2;

    int general = 1;
    for (int i = min; i > 0; i--)
    {
        if (d1 % i == 0 && d2 % i == 2)
        {
            general = i;
            i = 0;
        }
    }

    int denominator = d1 * d2 / general;
    int numerator = (d2 / general * n1) + (d1 / general * n2);

    return (numerator, denominator);
}

void SumOfTheFractions()
{
(int whole1, int numerator1, int denominator1) = Fraction();
(int whole2, int numerator2, int denominator2) = Fraction();

Console.WriteLine();
if (whole1 > 0) Console.Write(whole1);
if (numerator1 > 0) Console.Write($"[{numerator1}/{denominator1}]");
Console.Write(" + ");
if (whole2 > 0) Console.Write(whole2);
if (numerator2 > 0) Console.Write($"[{numerator2}/{denominator2}]");
Console.Write(" = ");

int wholeSum = whole1 + whole2;
(int numeratorSum, int denominatorSum) = Addition(numerator1, denominator1, numerator2, denominator2);

if (numeratorSum >= denominatorSum)
{
    wholeSum += (numeratorSum / denominatorSum);
    numeratorSum %= denominatorSum;
}

if (wholeSum > 0) Console.Write(wholeSum);
if (numeratorSum > 0) Console.WriteLine($"[{numeratorSum}/{denominatorSum}]");
}



SumOfTheFractions();