Console.Write("Введите число a:_");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b:_");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c:_");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Максимальное число из введенных :_");
if (a >b && a > c ) Console.WriteLine (a);
else if (b >a && b > c ) Console.WriteLine (b);
else Console.WriteLine (c);
