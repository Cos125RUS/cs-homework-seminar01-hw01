// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] FillArray()
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

int[,] Ordering(int[,] array)
{
    int x = 0;
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < m - 1 - j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    x = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = x;
                }
            }
        }
    }
    return array;
}



int[,] array = FillArray();
PrintArray(array);
array = Ordering(array);
PrintArray(array);
