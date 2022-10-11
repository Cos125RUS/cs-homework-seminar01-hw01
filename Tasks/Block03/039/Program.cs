// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void Filling(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Random.Shared.Next(1, 9);
    }
    System.Console.WriteLine(String.Join(' ', array));
}

void Multy(int[] array, int n)
{
    int[] multy = new int[n / 2];
    for (int i = 0; i < n / 2; i++)
    {
        multy[i] = array[i] * array[n - 1 - i];
    }
    System.Console.WriteLine(String.Join("  ", multy));
}

Console.Write("Size of array = ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Filling(array, size);
Console.WriteLine();
Multy(array, size);