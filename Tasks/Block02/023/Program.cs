//23. Показать таблицу квадратов чисел от 1 до N



int GetN()
{
    Console.Write("Enter N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;

}

//Console.WriteLine(GetN());


int n = GetN();

int[] array = new int [n];

int i = 0;
while (i < n)
{
    array[i] = i + 1;
    i++;
}

void Print(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.WriteLine($"{array[i]}^2 - {Math.Pow(array[i], 2)}");
        i++;
    }

}

Print(array);