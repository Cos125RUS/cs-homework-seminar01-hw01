// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int num = Random.Shared.Next(1,10);
Console.WriteLine("Предложенное число = "+num);

Console.Write("Ваше число = ");
int yourNum = Convert.ToInt32(Console.ReadLine());

int res = yourNum % num;

if (res == 0) Console.WriteLine(num+" кратно "+yourNum);
else Console.WriteLine(num+" не кратно "+yourNum+". Остаток от деления = "+ res);