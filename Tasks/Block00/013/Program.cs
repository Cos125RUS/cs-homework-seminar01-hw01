// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int num = Random.Shared.Next(1,10);
Console.WriteLine("Computer number = "+num);

Console.Write("Your number = ");
int yourNum = Convert.ToInt32(Console.ReadLine());

int res = yourNum % num;

if (res == 0) Console.WriteLine(num+" multiple "+yourNum);
else Console.WriteLine(num+" not multiple "+yourNum+". Remainder of the division = "+ res);