// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void FillArray(int[,,] arr, int n, int m, int h)
{
    int number = 10 + 2 * (2 * (n - 1) + (m - 1)) + (h - 1);

    if (n > 0 && m > 0 && h > 0)
        arr[n - 1, m - 1, h - 1] = number;

    if (n > 0) FillArray(arr, n - 1, m, h);
    if (m > 0) FillArray(arr, n, m - 1, h);
    if (h > 0) FillArray(arr, n, m, h - 1);
}

void Print3DArray(int[,,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);
    int h = arr.GetLength(2);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < h; k++)
            {
                Console.WriteLine($"({i}:{j}:{k}) - {arr[i, j, k]}   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int n = 2,
    m = 2,
    h = 2;

int[,,] arr = new int[n, m, h];

FillArray(arr, n, m, h);
Print3DArray(arr);