int[,] CreateField()
{
    int[,] f = new int[20, 20];
    for (int i = 0; i < 19; i++)
    {
        f[i, 0] = 1;
        f[i, 19] = 1;
    }
    for (int i = 0; i < 20; i++)
    {
        f[19, i] = 1;
        f[0, i] = 1;
    }

    return f;
}

int[,] field = CreateField();

void PrintField()
{
    for (int i = 0; i < 20; i++)
        for (int j = 0; j < 20; j++)
        {
            Console.SetCursorPosition(20 + i, j);
            if (field[i, j] == 1) Console.Write('+');
        }
}

int[,] mapping = Copying();

// Выбор следующей фигуры
int[,] Choice(int n)
{
    int[,] shape1 = {{0,1,0,0},
                     {1,1,0,0},
                     {1,0,0,0},
                     {0,0,0,0}};

    int[,] shape2 = {{1,0,0,0},
                     {1,0,0,0},
                     {1,0,0,0},
                     {1,0,0,0}};

    int[,] shape3 = {{1,0,0,0},
                     {1,0,0,0},
                     {1,1,0,0},
                     {0,0,0,0}};

    int[,] shape4 = {{1,1,0,0},
                     {1,1,0,0},
                     {0,0,0,0},
                     {0,0,0,0}};

    int[,] shape5 = {{1,0,0,0},
                     {1,1,0,0},
                     {1,0,0,0},
                     {0,0,0,0}};

    switch (n)
    {
        case 1:
            return shape1;

        case 2:
            return shape2;

        case 3:
            return shape3;

        case 4:
            return shape4;

        default:
            return shape5;
    }
}

// Создание следующей фигуры
int[,] Copying()
{
    int[,] shape = Choice(Random.Shared.Next(1, 6));
    int[,] f = new int[4, 4];

    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            f[i, j] = shape[i, j];

    return f;
}

// Движение фигуры
void Figure(int x, int y)
{
    int k = 0,
        l = 0;

    for (int i = x - 1; i <= x + 2; i++)
    {
        for (int j = y - 1; j <= y + 2; j++)
        {
            Console.SetCursorPosition(20 + i, j);
            if (mapping[k, l] == 1) Console.Write("+");
            l++;
        }
        l = 0;
        k++;
    }
}



Console.CursorVisible = false;
int x = 10;
int y = 2;
int gameOver = 17;



// Логика отрисовки всего
new Thread(() =>
{
    while (true)
    {
        Console.Clear();
        Console.SetCursorPosition(20, 20);
        PrintField();
        Figure(x, y);
        Thread.Sleep(500);
        y++;
        if (y > gameOver)
        {
            mapping = Copying();
            y = 1;
        }
    }
}).Start();

// Логика проверки нажатия кнопок
while (true)
{
    var key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.LeftArrow)
    {
        if (x > 2) x--;
        Figure(x, y);
    }
    if (key == ConsoleKey.RightArrow)
    {
        if (x < 16) x++;
        Figure(x, y);
    }
    // if (key == ConsoleKey.Spacebar)
    // {
    //     // Figure(x++, y--);
    // }
}
