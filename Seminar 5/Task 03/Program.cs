// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Filling(double[] array, int n)
{
    // Random rand = new Random();
    double a, b;

    for (int i = 0; i < n; i++)
    {
        a = Random.Shared.Next(1, 99);
        b = Random.Shared.Next(1, 99);        
        array[i] = a / b;
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