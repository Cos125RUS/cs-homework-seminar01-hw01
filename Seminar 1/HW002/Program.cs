// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1, num2, num3, max;

Console.Write("num1 = ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("num2 = ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("num3 = ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);