// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray()
{
    int n = new Random().Next(2, 6);
    int m = new Random().Next(2, 6);
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

double[] Average(int[,] arr)
{
    double[] aver = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            aver[j] += arr[i, j];
        }
        aver[j] /= arr.GetLength(0);
    }
    return aver;
}

void PrintArray(int[,] arr, double[] aver)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    System.Console.WriteLine(String.Join("  ", aver));
}

int[,] array = FillArray();
double[] mid = Average(array);
PrintArray(array, mid);