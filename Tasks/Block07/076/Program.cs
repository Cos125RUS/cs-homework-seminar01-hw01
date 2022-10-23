(int[,], int, int) Breakdown(int n)
{
    int[,] groups = new int[n, n];
    groups[0, 0] = 1;
    int rows = 0;
    int columns = 0;

    for (int i = 2; i <= n; i++)
    {
        for (int j = 1; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                if (groups[j, k] > 0)
                {
                    if (i % groups[j, k] == 0) k = n;
                    else
                    {
                        // Полная проверка на взаимно простые числа
                        if (CommonDivisor(i, groups[j, k]) > 1) k = n;
                    }
                }
                else
                {
                    groups[j, k] = i;
                    rows = j;
                    if (columns < k) columns = k;
                    j = n;
                    k = n;
                }


            }
        }
    }

    return (groups, rows + 1, columns + 1);
}

void PrintArray(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"Line {i + 1}: ");
        for (int j = 0; j < columns; j++)
        {
            if (arr[i, j] > 0) Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int CommonDivisor(int n1, int n2)
{
    int count = 1;
    for (int i = 2; i < n2; i++)
    {
        if (n1 % i == 0 && n2 % i == 0)
        {
            count = i;
            break;
        }
    }
    return count;
}



Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

(int[,] arr, int rows, int columns) = Breakdown(n);
PrintArray(arr, rows, columns);