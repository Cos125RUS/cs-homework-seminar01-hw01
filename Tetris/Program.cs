// int[,] f = new int[25, 25];
int[,] mapping = {{1,0,0,0},
                  {1,1,0,0},
                  {0,1,0,0},
                  {0,0,0,0}};



void Figure(int x, int y)
{
    int k = 0,
        l = 0;

    // for (int i = x - 1; i <= x + 2; i++)
    // {
    //     for (int j = y - 1; j <= y + 2; j++)
    //     {
    //         if (mapping[k, l] == 1) f[i, j] = 1;
    //         l++;
    //     }
    //     k++;
    // }

    // Console.Clear();
    for (int i = x - 1; i <= x + 2; i++)
    {
        for (int j = y - 1; j <= y + 2; j++)
        {
            Console.SetCursorPosition(i, j);
          if (mapping[k, l] == 1) Console.Write("+");
            // if (f[i, j] == 1) Console.Write("+");
            // Console.Write("+");
            l++;
        }
        l = 0;
        k++;
    }
}

// Обнуление
// void Zero()
// {
//     for (int i = 0; i < 25; i++)
//     {
//         for (int j = 0; j < 25; j++)
//         {
//             f[i, j] = 0;
//         }
//     }
// }


Console.CursorVisible = false;
int x = 10;
int y = 2;



// Логика отрисовки всего
new Thread(() =>
{
    while (true)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 15);
        System.Console.Write("+++++++++++++++++++++++++++++++++++++++");
        Figure(x, y);
        Thread.Sleep(500);
        y++;
        if (y > 15)
        {
            y = 1;
            // Zero();
        }
    }
}).Start();

// Логика проверки нажатия кнопок
while (true)
{
    var key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.LeftArrow)
    {
        x--;
        Figure(x, y);
    }
    if (key == ConsoleKey.RightArrow)
    {
        x++;
        Figure(x, y);
    }
    // if (key == ConsoleKey.Spacebar)
    // {
    //     // Figure(x++, y--);
    // }
}
