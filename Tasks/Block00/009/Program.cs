//Показать последнюю цифру трёхзначного числа

int num = Random.Shared.Next(100, 999);
Console.WriteLine("num = " + num);

int res = num%10;
Console.WriteLine("res = "+res);