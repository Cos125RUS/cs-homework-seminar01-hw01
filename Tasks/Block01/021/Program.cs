// Программа проверяет пятизначное число на палиндромом.

//int num = Random.Shared.Next(10000, 99999);
//Console.WriteLine("Number = "+num);
Console.Write("Number = ");
int num = Convert.ToInt32(Console.ReadLine());


if (num / 10000 == num % 10)
{
    if (num/1000%10==num%100/10) Console.WriteLine("The number is a polyndrom");
}
else Console.WriteLine("The number is not a polyndrom");
