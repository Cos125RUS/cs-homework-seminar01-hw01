//Показать вторую цифру трёхзначного числа

//int num = 347;
Console.Write("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

num /= 10;
num %= 10;

Console.Write("Вторая цифра - ");
Console.WriteLine(num);