// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 


int[,] Spiral()
{
    int n = new Random().Next(4, 9);
    int m = new Random().Next(4, 9);

    int[,] arr = new int[n, m];

    int count = 0;
    int direction = 1;
    int a = 0;
    int b = 0;
    int end = n * m;

    while (count < end)
    {
        switch (direction)
        {
            case 1:
                for (int j = b; j < m; j++)
                {
                    count++;
                    arr[a, j] = count;

                    if (j == m - 1)
                    {
                        direction = 2;
                        a++;
                    }
                }
                break;

            case 2:
                for (int i = a; i < n; i++)
                {
                    count++;
                    arr[i, m - 1] = count;

                    if (i == n - 1)
                    {
                        direction = 3;
                        m--;
                    }
                }
                break;

            case 3:
                for (int j = m - 1; j >= b; j--)
                {
                    count++;
                    arr[n - 1, j] = count;

                    if (j == b)
                    {
                        direction = 4;
                        n--;
                    }
                }
                break;

            case 4:
                for (int i = n - 1; i >= a; i--)
                {
                    count++;
                    arr[i, b] = count;

                    if (i == a)
                    {
                        direction = 1;
                        b++;
                    }
                }
                break;
        }
    }
    return (arr);
}

void PrintArray(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);
    Console.WriteLine("n = " + n);
    Console.WriteLine("m = " + m);
    Console.WriteLine();


    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,] array = Spiral();
PrintArray(array);