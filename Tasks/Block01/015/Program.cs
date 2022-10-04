// Дано число. Проверить кратно ли оно 7 и 23

int num = Random.Shared.Next(100,999);
Console.WriteLine("num = "+num);

void Multiple(int num)
{
    int i = 0;

    if (num % 7 == 0) 
    {
        Console.WriteLine(num + " multiple 7");
        i++;
    }

    if (num % 23 == 0) 
    {
        Console.WriteLine(num + " multiple 23");
        i++;
    }

    if (i == 0) Console.WriteLine (num + " not multiple 7 or 23");
}

Multiple(num);