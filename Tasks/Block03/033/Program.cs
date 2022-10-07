// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int size = 12,
    sum = 0;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = Random.Shared.Next(0, 9);
    Console.Write(array[i] + "  ");
    sum += array[i];
}

Console.WriteLine();
Console.WriteLine("Sum = " + sum);