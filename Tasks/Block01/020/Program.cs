// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Quarter?   ");
int quarter = Convert.ToInt32(Console.ReadLine());
while (quarter < 1 || quarter > 4)
{
    Console.Write("Enter a number between 1 and 4   ");
    quarter = Convert.ToInt32(Console.ReadLine());  
}

void Coordinate(int q)
{   
    if (q < 3) Console.WriteLine("x has a range from 0 to +n");
    else Console.WriteLine("x has a range from -n to 0");
    if (q == 1 || q == 4) Console.WriteLine("y has a range from 0 to +n");
    else Console.WriteLine("y has a range from -n to 0");
}

Coordinate(quarter);