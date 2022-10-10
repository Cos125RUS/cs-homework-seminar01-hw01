// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumOfDigits(int[] array, int size)
{
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        sum += array[i];
    }
    return sum;
}

int SizeOfNumber(int n)
{
    int count = 0;

    while (n > 10)
    {
        n /= 10;
        count++;
    }
    return count + 1;
}

void Converter(int[] array, int n, int count)
{
    for (int i = 0; i < count; i++)
    {
        array[i] = n % 10;
        n /= 10;
    }
}


int number;
do
{
    Console.Write("Number = ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) Console.WriteLine("Error! Try again.");
} while (number < 0);


int size = SizeOfNumber(number);
int[] array = new int[size];

Converter(array, number, size);

int sum = SumOfDigits(array, size);
Console.WriteLine(number + " -> " + sum);