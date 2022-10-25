// Вид стартового поля
int[,] CreateField()
{
    int[,] f = new int[22, 20];

    for (int i = 0; i < 19; i++)
    {
        f[i, 0] = 1;
        f[i, 19] = 1;
    }

    for (int i = 0; i < 20; i++)
    {
        f[0, i] = 1;
        for (int j = 19; j < 22; j++)
            f[j, i] = 1;
    }

    return f;
}

// Инициализация поля
int[,] field = CreateField();


// Отрисовка поля
void PrintField()
{
    for (int i = 0; i < 20; i++)
        for (int j = 0; j < 20; j++)
        {
            Console.SetCursorPosition(20 + i, j);
            if (field[i, j] == 1) Console.Write('*');
        }
}


// Запись выбранной фигуры
(int[,] mapping, int row, int column) = Copying();


// Изменения поля
void ChangeField(int x, int y)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1) field[x + i, j + y] = 1;
}


// Выбор следующей фигуры
int[,] Choice(int n)
{
    int[,] shape1 = {{0,1},
                     {1,1},
                     {1,0}};

    int[,] shape2 = { { 1, 1, 1, 1 } };

    int[,] shape3 = {{1,0},
                     {1,0},
                     {1,1}};

    int[,] shape4 = {{1,1},
                     {1,1}};

    int[,] shape5 = {{1,0},
                     {1,1},
                     {1,0}};

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
(int[,], int, int) Copying()
{
    int[,] shape = Choice(Random.Shared.Next(1, 6));
    int n = shape.GetLength(0);
    int m = shape.GetLength(1);
    int[,] f = new int[n, m];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            f[i, j] = shape[i, j];

    return (f, n, m);
}


// Поворот фигуры
(int[,], int, int) Twist(int[,] arr, int n, int m)
{
    int[,] revers = new int[m, n];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            revers[j, n - 1 - i] = arr[i, j];

    return (revers, m, n);
}


// Движение фигуры
void Figure(int x, int y)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            Console.SetCursorPosition(20 + i + x, j + y);
            if (mapping[i, j] == 1) Console.Write("*");
        }
}


// Проверка падения фигуры
bool Drop(int x, int y)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1 && field[x + i , j + y + 1] == 1) return true;

    return false;
}


// Начальные параметры
Console.CursorVisible = false;
int x = 10;
int y = 2;
int time = 500;


// Логика отрисовки всего
new Thread(() =>
{
    while (true)
    {
        Console.Clear();
        Console.SetCursorPosition(20, 20);
        PrintField();
        Figure(x, y);
        Thread.Sleep(time);
        y++;
        // if (y + column >= 19)
        if (Drop(x,y))
        {
            ChangeField(x, y);
            (mapping, row, column) = Copying();
            y = 1;
            x = 10;
            time = 500;
        }
    }
}).Start();


// Логика проверки нажатия кнопок
while (true)
{
    var key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.LeftArrow)
    {
        if (x > 1) x--;
        Figure(x, y);
    }

    if (key == ConsoleKey.RightArrow)
    {
        if (x < 19 - row) x++;
        Figure(x, y);
    }

    if (key == ConsoleKey.Spacebar)
    {
        (mapping, row, column) = Twist(mapping, row, column);
        while (x > 19 - row) x--;
        while (x < 1) x++;
        Figure(x, y);
    }

    if (key == ConsoleKey.DownArrow)
    {
        time = 100;
        Figure(x, y);
    }
}
