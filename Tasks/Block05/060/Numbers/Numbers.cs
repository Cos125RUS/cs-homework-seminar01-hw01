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

int[] FrequencyAnalysis(int[,] arr, int n, int m)
{
    int[] frequency = new int[10];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            ++frequency[arr[i, j]];
        }
    }
    return frequency;
}

void PrintFrequency(int[] freq)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"The number {i} met in the array - {freq[i]} times");
    }
}


(int[,] array, int n, int m) = FillArray();
PrintArray(array, n, m);
int[] frequency = FrequencyAnalysis(array, n, m);
PrintFrequency(frequency);