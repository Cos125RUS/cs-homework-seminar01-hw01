// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] FillArray()
{
    int n = new Random().Next(2, 10);
    int m = new Random().Next(2, 10);
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(2, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] Square(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] array = FillArray();
Console.WriteLine();
array = Square(array);