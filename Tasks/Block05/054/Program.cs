// В матрице чисел найти сумму элементов главной диагонали


int[,] FillArray()
{
    int n = new Random().Next(2, 10);    
    int[,] arr = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(2, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

int Sum(int[,] arr)
{
    int n = arr.GetLength(0),
        sum = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j ) sum += arr[i,j];           
        }        
    }
    return sum;
}

int[,] array = FillArray();
Console.WriteLine();
int sum = Sum(array);
System.Console.WriteLine("Sum = " + sum);