//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


void Filling(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Random.Shared.Next(0, 999);
    }
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
int[] range = {10,99};

Filling(array, size);

int elements = Finding(array,range[0],range[1], size);

Console.WriteLine("Number of elements - " + elements);