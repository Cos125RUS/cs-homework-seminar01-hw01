// 12. Удалить вторую цифру трёхзначного числа

int num = Random.Shared.Next(100, 999);
Console.WriteLine("num = " + num);

int n1, n3, res;

n1 = num/100;
n3 = num%10;

res = n1*10+n3;

Console.WriteLine("res = " + res);
