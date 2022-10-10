// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int n)
{
    double[] cube = new double[n];

    for (int i = 0; i < n; i++)
    {
        cube[i] = Math.Pow((i + 1), 3);
        Console.WriteLine((i + 1) + "^3 = " + cube[i]);
    }
}

Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);