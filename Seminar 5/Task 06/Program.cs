// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] Creating(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Random.Shared.Next(0, 9);
        Console.Write(array[i] + "  ");
    }

    Console.WriteLine();
    return array;
}

int[] Change(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] *= -1;
        Console.Write(array[i] + " ");
    }
    return array;
}


int size = 12;
int[] array = Creating(size);
array = Change(array, size);
// System.Console.WriteLine(String.Join(' ', array));
