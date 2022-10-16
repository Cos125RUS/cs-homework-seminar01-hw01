// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


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

Console.WriteLine("Sum of positive elements =  " + Summation(array, size, 1));
Console.WriteLine("Sum of negative elements = -" + Summation(array, size, -1));

