// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] Creation(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Random.Shared.Next(0, 10);
    }
    System.Console.WriteLine(String.Join(' ', array));
    return array;
}

bool Finding(int[] array, int size, int num)
{
    bool find = false;

    for (int i = 0; i < size; i++)
    {        
        if (array[i] == num) find = true;
    }
    return find;
}



int size = 12,
    num = Random.Shared.Next(0, 10);
int[] array = Creation(size);


if (Finding(array, size, num) == true) Console.WriteLine("The number " + num + " is present in the array");
else Console.WriteLine("The number " + num + " is not present in the array");