// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int SumOgNumbers(int[] array, int n)
{
    int sum = 0;
    for (int i = 0; i < n; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

void Filling(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Random.Shared.Next(0, 9);
    }
    System.Console.WriteLine(String.Join(' ', array));
}

Console.Write("Size of array = ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int[size];

Filling(array,size);

int sum = SumOgNumbers(array, size);

Console.WriteLine("Sum = " + sum);