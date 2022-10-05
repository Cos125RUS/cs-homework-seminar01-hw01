// Найти сумму чисел от 1 до А

Console.Write("A = ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum (int a)
{
    if (a == 1) return 1;
    else return (a + Sum(a-1));
}

Console.WriteLine(Sum(a));