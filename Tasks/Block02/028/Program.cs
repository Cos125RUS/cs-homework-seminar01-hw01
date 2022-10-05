// Подсчитать сумму цифр в числе

int num = new Random().Next(1, 100000000);
Console.WriteLine("Number = " + num);

int Sum(int n)
{
    if (n < 10) 
    {
        return n%10;
    }
    else 
    {        
        return (n%10 + Sum(n / 10));
    }
}

Console.WriteLine("The sum of the digits in a number = " + Sum(num));
