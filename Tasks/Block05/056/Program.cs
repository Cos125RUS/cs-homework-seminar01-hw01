// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] FillArray()
{
    int n = new Random().Next(3, 9);
    int m = new Random().Next(3, 9);
    // Console.WriteLine("n = " + n);
    // Console.WriteLine("m = " + m);
    // Console.WriteLine();
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            // Console.Write($"{arr[i, j]}   ");
        }
        // Console.WriteLine();
    }
    return arr;
}

void PrintArray(int[,] arr)
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
}

int[,] Change(int[,] array)
{
    int m = array.GetLength(1),
        n = array.GetLength(0) - 1;

    int[] new_array = new int[m];

    for (int i = 0; i < m; i++)
    {
        new_array[i] = array[0, i];
        array[0, i] = array[n, i];
        array[n, i] = new_array[i];
    }
    return array;
}



int[,] array = FillArray();
// System.Console.WriteLine();
PrintArray(array);
array = Change(array);
PrintArray(array);