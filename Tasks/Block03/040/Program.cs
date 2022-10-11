// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void Filling(double[] array, int n)
{
    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        array[i] = rand.NextDouble() + Random.Shared.Next(0, 99);
        Console.WriteLine(array[i]);
    }
    
}

double Difference(double[] array, int n)
{
    double max = array[0], min = array[0], dif = 0;

    for (int i = 1; i < n; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    dif = max - min;
    return dif;
}

Console.Write("Size of array = ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

Filling(array, size);
Console.WriteLine();

double res = Difference(array, size);
Console.WriteLine("Difference = " + res);