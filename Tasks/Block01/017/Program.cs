// 1. По двум заданным числам проверять является ли первое квадратом второго

int num1, num2;
Console.Write("num1 = ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("num2 = ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1*num1 == num2) Console.WriteLine("num2 square of num1");
else if (num2*num2 == num1) Console.WriteLine("num1 square of num2");
else Console.WriteLine("Faild");

