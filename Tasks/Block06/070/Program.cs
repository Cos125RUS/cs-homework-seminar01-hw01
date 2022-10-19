// Найти сумму цифр числа

int sum = 0;

int SumOfDigitsInNumber(int n)
{
    if (n == 0) return sum;
    else
    {
        sum += n % 10;
        return SumOfDigitsInNumber(n / 10);
    }
}




Console.Write("Number = ");
int num = Convert.ToInt32(Console.ReadLine());
sum = SumOfDigitsInNumber(num);
System.Console.WriteLine("Sum = " + sum);