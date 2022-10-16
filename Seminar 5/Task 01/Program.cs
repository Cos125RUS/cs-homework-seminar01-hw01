// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int EvenNumbers(int[] array, int size)
{
    int even = 0;

    for (int i = 0; i < size; i++)
    {
        array[i] = Random.Shared.Next(100, 999);
        if (array[i] % 2 == 0) even++;
    }
    System.Console.WriteLine(String.Join(' ', array));
    return even;
}

int size = 10;
int[] array = new int[size];

int even = EvenNumbers(array, size);

Console.WriteLine("Even numbers in an array " + even);
