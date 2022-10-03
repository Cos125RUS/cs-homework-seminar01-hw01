// Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("num = ");
int num = Convert.ToInt32(Console.ReadLine());

void ThirdNumber(int num)
{
    if (num < 100) 
    {
        Console.WriteLine("Your number does not have a third digit");
    }
    else
    {
        while (num > 1000) num /= 10;
        Console.WriteLine("Third digit of your number is " + num%10);
    }
}

ThirdNumber(num);