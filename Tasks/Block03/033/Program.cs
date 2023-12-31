﻿// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] Creation(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    System.Console.WriteLine(String.Join(' ', array));
    return array;
}

int Summation(int[] array, int size, int determinant)
{
    int sum = 0;
    if (determinant > 0)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] > 0) sum += array[i];
        }
    }
    else
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] < 0) sum -= array[i];
        }
    }
    return sum;
}

int size = 12;
int[] array = Creation(size);

Console.WriteLine("Sum of positive elements = " + Summation(array, size, 1));
Console.WriteLine("Sum of negative elements = -" + Summation(array, size, -1));