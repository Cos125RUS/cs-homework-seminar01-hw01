// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int size = 100,
    even = 0,
    odd = 0;

int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = Random.Shared.Next(100, 999);
    if (array[i] % 2 == 0) even++;
    else odd++;
}

Console.WriteLine("Even numbers in an array " + even);
Console.WriteLine("Odd numbers in an array " + odd);