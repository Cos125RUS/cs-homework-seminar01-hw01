// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).


int[,] FillArray()
{
    int n = new Random().Next(3, 6);
    int m = new Random().Next(3, 6);

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

bool Square(int[,] array)
{
    bool w = false;
    int n = array.GetLength(0),
        m = array.GetLength(1);

    if (n == m) w = true;

    return w;
}

int[,] Reversal(int[,] array)
{
    int n = array.GetLength(0),
        m = array.GetLength(1);

    int[,] new_array = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            new_array[j, i] = array[i, j];
        }
    }

    return new_array;
}


int[,] array = FillArray();
PrintArray(array);

if (Square(array) == false) Console.WriteLine("Matrix is not square!");
else
{
    array = Reversal(array);
    PrintArray(array);
}