// Определить количество цифр в числе

int num = new Random().Next(1, 100000000);
Console.WriteLine("Number = " + num);

int Size(int n)
{
    if (n < 10) 
    {
        return 1;
    }
    else 
    {
        return (1 + Size(n / 10));
    }
}

Console.WriteLine("Size of number = " + Size(num));