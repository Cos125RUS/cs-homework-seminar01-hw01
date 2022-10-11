// Определить сколько чисел больше 0 введено с клавиатуры


int Filling(int[] array, int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write("N" + (i + 1) + " : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Size of array = ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Console.WriteLine();
Console.WriteLine(Filling(array, size) + " positive numbers");
