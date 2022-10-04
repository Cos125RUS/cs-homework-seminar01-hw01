// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int Coordinate()
{
    int x = Random.Shared.Next(-9, 10);
    while (x == 0) x = Random.Shared.Next(-9, 10);
    Console.WriteLine(x+"   ");
    return x;
}

int x = Coordinate();
int y = Coordinate();

void Quarter(int x, int y)
{
    if (x > 0)
    {
        if (y > 0) Console.WriteLine("1 quarter");
        else Console.WriteLine("2 quarter");
    }
    else
    {
        if (y > 0) Console.WriteLine("4 quarter");
        else Console.WriteLine("3 quarter");
    }
}

Quarter(x, y);