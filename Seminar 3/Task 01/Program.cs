// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Enter()
{
    int num;
    do
    {
        Console.Write("Number = ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num < 10000) Console.Write("Invalid value. Try again.");
    } while (num < 10000);

    return num;
}

bool Polyndrom(int num)
{
    return ((num / 10000 == num % 10) && (num / 1000 % 10 == num % 100 / 10));
}


int num = Enter();
if (Polyndrom(num) == true) Console.WriteLine("The number is a polyndrom");
else Console.WriteLine("The number is not a polyndrom");

