// Сформировать трехмерный массив не повторяющимися двузначными числами. 
// Показать его построчно, выводя на экран индексы соответствующего элемента.


int[,,] FillArray()
{
    int n = Random.Shared.Next(3, 8),
        m = Random.Shared.Next(3, 8),
        h = Random.Shared.Next(3, 8);

    int[,,] arr = new int[n, m, h];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < h; k++)
            {
                do
                {
                    arr[i, j, k] = new Random().Next(10, 100);
                } while (Reconciliation(i, j, k, arr, arr[i, j, k]) == false);
            }
        }
    }

    return arr;
}

bool Reconciliation(int a, int b, int c, int[,,] arr, int number)
{
    bool check = true;

    for (int i = 0; i <= a; i++)
    {
        for (int j = 0; j <= b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                if (number == arr[i, j, k])
                {
                    check = false;                    
                    break;
                }

            }
        }
    }

    return check;
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



int[,,] array = FillArray();
Print3DArray(array);