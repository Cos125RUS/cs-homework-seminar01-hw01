// Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника


int[,] PascalTriangle(int n)
{
    int[,] arr = new int[n, (n * 2 + 1)];
    arr[0, n] = 1;

    for (int i = 1; i < n; i++)
    {
        for (int j = n - i; j < n + i + 1; j += 2)
        {
            arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j + 1];
        }
    }
    return arr;
}

void PrintTriangle(int[,] arr, int n)
{
    Console.WriteLine();
    char sp = Convert.ToChar(32);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < (n * 2 + 1); j++)
        {
            if (arr[i,j] == 0) Console.Write(sp);
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}






Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] triangle = PascalTriangle(n);
PrintTriangle(triangle, n);

