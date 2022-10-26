// Вид стартового поля
int[,] CreateField()
{
    int[,] f = new int[22, 20];

    for (int i = 0; i < 20; i++)
    {
        f[i, 0] = 1;
        f[0, i] = 1;
        f[i, 19] = 1;
        for (int j = 19; j < 22; j++)
            f[j, i] = 1;
    }

    return f;
}


// Отрисовка поля
void PrintField(int[,] field)
{
    for (int i = 0; i < 20; i++)
        for (int j = 0; j < 20; j++)
        {
            Console.SetCursorPosition(20 + i, j);
            if (j == 0 || j == 19) Console.Write(Convert.ToChar(22));
            if ((i == 0 || i == 19) && j > 0 && j < 19) Console.Write(Convert.ToChar(19));
            if (field[i, j] == 1 && i > 0 && i < 19 && j > 0 && j < 19) Console.Write(Convert.ToChar(4));
        }
}


// Изменения поля
void ChangeField(int x, int y, int[] lineCounter, int[,] field, int [,] mapping, int row, int column)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1)
            {
                field[x + i, j + y - 1] = 1;
                ++lineCounter[j + y];
                if (lineCounter[j + y] == 18) Reduction(j + y, field, lineCounter);
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
void Figure(int x, int y, int [,] mapping, int row, int column)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            Console.SetCursorPosition(20 + i + x, j + y);
            if (mapping[i, j] == 1) Console.Write(Convert.ToChar(4));
        }
}


// Проверка падения фигуры
bool Drop(int x, int y, int[,] field, int [,] mapping, int row, int column, bool gameOver)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1 && field[x + i, j + y] == 1)
            {
                if (y - column < 1) gameOver = true; // Проверка проигрыша
                return true;
            }

    return false;
}


// Сокращение линий
void Reduction(int line, int[,] field, int[] lineCounter)
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
bool SideTest(int x, int y, int direction, int[,] field, int [,] mapping, int row, int column)
{
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (mapping[i, j] == 1 && field[x + i + direction, j + y] == 1) return true;

    return false;
}


// Инициализация поля
int[,] field = CreateField();
int[] lineCounter = new int[20];

// Первая запись выбранной фигуры
(int[,] mapping, int row, int column) = Copying();

// Начальные параметры
Console.CursorVisible = false;
int x = 10;
int y = 2;
int time = 500;
bool gameOver = false;

// Логика отрисовки всего
new Thread(() =>
{
    while (true)
    {
        while (time > 500) { }

        Console.Clear();
        Console.SetCursorPosition(20, 20);
        PrintField(field);
        Figure(x, y, mapping, row, column);
        Thread.Sleep(time);

        if (gameOver)
        {
            Console.SetCursorPosition(25, 22);
            System.Console.WriteLine("GAME OVER!");
            break;
        }

        y++;

        if (Drop(x, y, field, mapping, row, column, gameOver))
        {
            ChangeField(x, y, lineCounter, field, mapping, row, column);
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
        if (x > 1 && !SideTest(x, y, -1, field, mapping, row, column)) x--;
        Figure(x, y, mapping, row, column);
    }

    if (key == ConsoleKey.RightArrow)
    {
        if (x < 19 - row && !SideTest(x, y, 1, field, mapping, row, column)) x++;
        Figure(x, y, mapping, row, column);
    }

    if (key == ConsoleKey.Spacebar)
    {
        (mapping, row, column) = Twist(mapping, row, column);
        while (x > 19 - row) x--;
        while (x < 1) x++;
        Figure(x, y, mapping, row, column);
    }

    if (key == ConsoleKey.DownArrow)
    {
        time = 100;
        Figure(x, y, mapping, row, column);
    }

    if (key == ConsoleKey.P)
    {
        if (time <= 500)
        {
            time = 99999999;
            Console.SetCursorPosition(27, 22);
            System.Console.WriteLine("PAUSE");
        }
        else time = 500;
    }
}