int a, b, max;

a = Random.Shared.Next(-10, 11);
b = Random.Shared.Next(-10, 11);

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("max = ");
Console.WriteLine(max);