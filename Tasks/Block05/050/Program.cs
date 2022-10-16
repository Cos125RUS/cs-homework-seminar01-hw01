// В двумерном массиве n×k заменить четные элементы на противоположные

int[,] Creation(int n, int k)
{
    int[,] array = new int[n, k];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = Random.Shared.Next(0, 100);
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    return array;
}

int Size()
{
    int number = Random.Shared.Next(2, 10);
    return number;
}

int[,] Change(int[,] array, int n, int k)
{
    int m;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k - 1; j += 2)
        {
            m = array[i, j];
            array[i, j] = array[i, j + 1];
            array[i, j + 1] = m;
            Console.Write(array[i, j] + "  ");
            Console.Write(array[i, j + 1] + "  ");
        }
        if (k % 2 != 0) Console.WriteLine(array[i, k - 1]);
        else Console.WriteLine();
    }
    // System.Console.WriteLine(string.Join(' ', array));
    return array;
}

int n = Size(),
    k = Size();

Console.WriteLine("n = " + n);
Console.WriteLine("k = " + k);


int[,] array = Creation(n, k);
Console.WriteLine();
array = Change(array, n, k);