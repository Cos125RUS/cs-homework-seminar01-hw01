// Написать программу преобразования десятичного числа в двоичное

void Converter(int n)
{
    int degree = 0;
    while (Math.Pow(2, degree) <= n)
    {
        degree++;
    }
    //Console.WriteLine(degree);

    int[] array = new int[degree];

    for (int i = degree - 1; i >= 0; i--)
    {
        array[i] = n % 2;
        n /= 2;
    }

    System.Console.WriteLine(String.Join("", array));

    // string findNumber = Convert.ToString(array);
    // return findNumber;
}

Console.Write("Enter the number = ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
Converter(decimalNumber);

// Console.WriteLine();
// Console.WriteLine(Converter(decimalNumber));