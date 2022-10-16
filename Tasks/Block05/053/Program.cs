// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] FillArray()
{
    int n = new Random().Next(2, 10);
    int m = new Random().Next(2, 10);
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(2, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

void FindInArray(int [,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number) Console.WriteLine($"{i}:{j}   ");
            // System.Console.WriteLine();
        }
    }
}


int[,] array = FillArray();
Console.WriteLine();

System.Console.Write("What's number? ");
int number = Convert.ToInt32(Console.ReadLine());
FindInArray(array, number);