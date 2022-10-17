// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] ClientNumbers(int m)
{
    int[] array = new int[m];
    for (int i =0; i < m; i++)
    {
        Console.Write("Enter next number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveNumber(int[] array, int m)
{
    int counter = 0;
    for (int i = 0; i < m; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}


int m = new Random().Next(2,10);
int[] array = ClientNumbers(m);
System.Console.WriteLine(string.Join(' ', array));
int counter = PositiveNumber(array, m);
Console.WriteLine(("Positive number = " + counter));