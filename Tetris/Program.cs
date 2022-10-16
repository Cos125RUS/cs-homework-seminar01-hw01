
void Figure(int x, int y)
{
  Console.Clear();
  for (int i = x - 1; i <= x + 1; i++)
  {
    for (int j = y - 1; j <= y + 1; j++)
    {
      Console.SetCursorPosition(i, j);
      Console.Write("+");
    }
  }
}
Console.CursorVisible = false;
int x = 10;
int y = 2;

// Логика отрисовки всего
new Thread(() =>
{
  while (true)
  {
    Figure(x, y);
    Thread.Sleep(500);
    y++;
    if (y > 15) y = 1;
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
}
