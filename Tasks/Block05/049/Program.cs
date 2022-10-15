// Показать двумерный массив размером m×n заполненный вещественными числами

// Показать двумерный массив размером m×n заполненный целыми числами

double[,] Creation(int n, int m)
{
    double[,] array = new double[n, m];
    double a, b;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            a = Random.Shared.Next(1, 100);            
            b = Random.Shared.Next(1, 100);                        
            array[i, j] = a / b;
        }
    }
    return array;
}

int Size()
{
    int number = Random.Shared.Next(2, 10);
    return number;
}

void Print(double[,] array, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

int n = Size(),
    m = Size();

double[,] array = Creation(n, m);

Print(array, n, m);