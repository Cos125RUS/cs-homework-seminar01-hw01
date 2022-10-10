//41. Выяснить являются ли три числа сторонами треугольника

int Enter()
{
    int size;
    do
    {
        Console.Write("Number 1 = ");
        size = Convert.ToInt32(Console.ReadLine());
    } while (size < 1);
    return size;
}

bool Triangle(int a, int b, int c)
{
    return (a + b > c && a + c > b && b + c > a);

}

int num1 = Enter();
int num2 = Enter();
int num3 = Enter();

Console.WriteLine(Triangle(num1, num2, num3));