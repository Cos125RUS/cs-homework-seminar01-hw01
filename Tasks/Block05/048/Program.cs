// Показать двумерный массив размером m×n заполненный целыми числами

int[,] Creation(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            array[i, j] = Random.Shared.Next(0, 100);
    }
    return array;
}

int Size()
{
    int number = Random.Shared.Next(2, 10);
    return number;
}

void Print(int[,] array, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

int n = Size(),
    m = Size();

int[,] array = Creation(n, m);

Print(array, n, m);