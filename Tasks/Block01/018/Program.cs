// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

int x = Random.Shared.Next(0, 2);
int y = Random.Shared.Next(0, 2);

Console.WriteLine("x = " + x + "   y = " + y);

int Dis(int x, int y)
{
    if (x == 0 && y == 0) return 0;
    else return 1;
}

int Neg(int num)
{
    if (num == 1) return 0;
    else return 1;
}

int Con(int x, int y)
{
    if (x == 1 && y == 1) return 1;
    else return 0;
}

Console.WriteLine(Neg(Dis(x, y)) + " = " + Con(Neg(x), Neg(y)));
