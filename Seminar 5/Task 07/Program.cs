// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


void Filling(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Random.Shared.Next(0, 999);
    }
    System.Console.WriteLine(String.Join(' ', array));
}

int Finding(int[] array, int a, int b, int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] >= a && array[i] <= b) count++;
    }
    return count;
}

int size = 123;
int[] array = new int[size];
int[] range = { 10, 99 };

Filling(array, size);

int elements = Finding(array, range[0], range[1], size);

Console.WriteLine("Number of elements - " + elements);