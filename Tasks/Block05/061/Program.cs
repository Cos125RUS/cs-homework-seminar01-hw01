// Найти произведение двух матриц

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

int[,] Multiplication(int[,] first, int[,] second)
{
    int n1 = first.GetLength(0);
    int m1 = first.GetLength(1);
    int n2 = second.GetLength(0);
    int m2 = second.GetLength(1);

    int[,] array = new int[n1, m2];

    if (m1 != n2) Console.WriteLine("These matrices do not multiply");
    else
    {
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                for (int k = 0; k < m1; k++)
                {
                    array[i, j] += first[i, k] * second[k, j];
                }
            }
        }

        PrintArray(array);
    }

    return array;
}


int[,] first_array = FillArray();
int[,] second_array = FillArray();
PrintArray(first_array);
PrintArray(second_array);

int[,] res = Multiplication(first_array, second_array);
