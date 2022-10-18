// В прямоугольной матрице найти строку с наименьшей суммой элементов.

(int[,], int n, int m) FillArray()
{
    int n = new Random().Next(3, 9);
    int m = new Random().Next(3, 9);

    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return (arr, n, m);
}

void PrintArray(int[,] arr, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

(int[] min_line, int line) Minimum(int[,] array, int n, int m)
{
    int min = 0,
        line = 0;

    for (int i = 0; i < n; i++)
    {
        int sum = 0;

        for (int j = 0; j < m; j++)
        {
            sum += array[i, j];
        }

        if (i == 0)
        {
            min = sum;
            line = 0;
        }
        else
        {
            if (sum < min)
            {
                min = sum;
                line = i;
            }
        }

    }

    int[] min_line = new int[m];
    for (int i = 0; i < m; i++)
    {
        min_line[i] = array[line, i];
    }

    return (min_line, line);
}


(int[,] array, int n, int m) = FillArray();
PrintArray(array, n, m);
(int[] min_line, int line) = Minimum(array, n, m);
Console.WriteLine("Min line - " + line);
System.Console.WriteLine(String.Join(' ', min_line));



