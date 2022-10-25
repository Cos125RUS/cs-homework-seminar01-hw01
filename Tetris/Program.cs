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
int[] lineCounter = new int[20];

// Отрисовка поля
void PrintField()
{
    for (int i = 0; i < 20; i++)
        for (int j = 0; j < 20; j++)
        {
            Console.SetCursorPosition(20 + i, j);
            if (field[i, j] == 1) Console.Write('*');
            Console.SetCursorPosition(13, j);
            Console.Write(lineCounter[j]);
        }


}


// Первая запись выбранной фигуры
(int[,] mapping, int row, int column) = Copying();


// Изменения поля
void ChangeField(int x, int y)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1)
            {
                field[x + i, j + y] = 1;
                ++lineCounter[j + y];
                if (lineCounter[j + y] == 18) Reduction(j + y);
            }
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
            if (mapping[i, j] == 1 && field[x + i, j + y + 1] == 1) return true;

    return false;
}


// Сокращение линий
void Reduction(int line)
{
    for (int i = line; i > 0; i--)
    {
        for (int j = 1; j < 19; j++)
            field[j, i] = field[j, i - 1];
        lineCounter[i] = lineCounter[i - 1];
    }

    for (int i = 1; i < 19; i++)
        field[i, 1] = 0;
}


// Проверка на врезаие в фигуры слева
bool LeftTest(int x, int y, int direction)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1 && field[x + i + 1 * direction, j + y] == 1) return true;

    return false;
}


// Конец игры
bool GameOver(int x, int y)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1 && field[x + i, j + y + 1] == 1)
                if (j - column <= 1) return true;

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
        if (GameOver(x, y))
        {
            Console.SetCursorPosition(25, 25);
            System.Console.WriteLine("GAME OVER!");
            break;
        }
        y++;
        if (Drop(x, y))
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
        if (x > 1 && !LeftTest(x, y, -1)) x--;
        Figure(x, y);
    }

    if (key == ConsoleKey.RightArrow)
    {
        if (x < 19 - row && !LeftTest(x, y, 1)) x++;
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