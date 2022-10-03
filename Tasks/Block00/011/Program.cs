// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = Random.Shared.Next(10, 99);
Console.WriteLine("num = " + num);

int n1, n2;

n1 = num/10;
n2 = num%10;

Console.Write("max n - ");
if (n1 > n2) Console.WriteLine(n1);
else Console.WriteLine(n2);