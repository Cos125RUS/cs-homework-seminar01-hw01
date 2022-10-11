// Написать программу преобразования десятичного числа в двоичное

string Converter(int n)
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
    // Console.Write("Binary number = ");
    // System.Console.WriteLine(String.Join("", array));

    string findNumber = string.Join("",array);
    return findNumber;
}

Console.Write("Enter the number = ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
string binaryNumber = Converter(decimalNumber);

//Console.WriteLine();
Console.WriteLine("Binary number = " + binaryNumber);