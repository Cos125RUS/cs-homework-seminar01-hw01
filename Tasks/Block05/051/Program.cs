// Задать двумерный массив следующим правилом: Aₘₙ = m+n

// int Size()
// {
//     int num = new Random().Next(2, 11);
//     return num;
// }

int[,] FillArray()
{
    int m = new Random().Next(2, 11);
    int n = new Random().Next(2, 11);
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = i + j;
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] array = FillArray();