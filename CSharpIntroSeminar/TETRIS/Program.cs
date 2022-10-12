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
int x = 10;
int y = 2;

// Логика отрисовки всего
new Thread(() =>
{
  while (true)
  {
    Figure(x, y);
    Thread.Sleep(900);
    y++;
    if (y > 17) y = 1;
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
  if (key == ConsoleKey.UpArrow)
  {
    y=1;
    Figure(x, y);
  }

}

