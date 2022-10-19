// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


int[,] FillArray()
{
    int n = new Random().Next(3, 10);
    int m = new Random().Next(3, 10);

    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
    return (arr);
}

void PrintArray(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Deletion(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);
    int min = arr[0, 0],
        x = 0,
        y = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }

    Console.WriteLine($"min = {min}");
    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");
    Console.WriteLine();

    int c = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = y; j < m - 1; j++)
        {
            c = arr[i, j];
            arr[i, j] = arr[i, j + 1];
            arr[i, j + 1] = c;
        }
    }

    for (int j = 0; j < m; j++)
    {
        for (int i = x; i < n - 1; i++)
        {
            c = arr[i, j];
            arr[i, j] = arr[i + 1, j];
            arr[i + 1, j] = c;
        }
    }

    int[,] new_array = new int[n - 1, m - 1];

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < m - 1; j++)
        {
            new_array[i, j] = arr[i, j];
        }
    }
    return new_array;
}





int[,] array = FillArray();
PrintArray(array);

array = Deletion(array);
PrintArray(array);
