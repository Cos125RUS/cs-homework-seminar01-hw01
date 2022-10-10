// опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
// без math.pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int a, int b)
{
    int res = 1;

    if (b == 0) return 1;
    else
    {
        for (int i = 0; i < b; i++)
        {
            res *= a;
        }
        return res;
    }
}

void Print(int a, int b, int res)
{
    string output = a + ", " + b + " -> " + res;
    Console.WriteLine(output);
}

int a;
do
{
    Console.Write("a = ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 0) Console.WriteLine("Error! Try again.");
} while (a == 0);

int b;
do
{
    Console.Write("b = ");
    b = Convert.ToInt32(Console.ReadLine());
    if (b < 0) Console.WriteLine("Error! Try again.");
} while (b < 0);

int result = Exponentiation(a, b);
Print(a, b, result);