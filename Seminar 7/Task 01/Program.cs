// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.


int[,] FillArray()
{
    int n = new Random().Next(3, 10);
    int m = new Random().Next(3, 10);
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

int FindElement(int[,] arr, int row, int column)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    if (row < n && column < m) return arr[row, column];
    else return -1;
}

void Program()
{
    int[,] array = FillArray();
    Console.WriteLine();

    System.Console.Write("What's position? ");
    string position = Console.ReadLine();

    var pos = position.IndexOf(':');

    int row = Convert.ToInt32(position.Substring(0, pos));
    int column = Convert.ToInt32(position.Substring(pos + 1));

    int number = FindElement(array, row, column);

    if (number == -1) Console.WriteLine("Number is not found");
    else Console.WriteLine("Find number is " + number);
}


Program();