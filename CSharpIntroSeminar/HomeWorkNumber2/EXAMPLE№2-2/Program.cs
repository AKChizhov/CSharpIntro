Console.Clear();
Console.WriteLine("Здравствуй пользователь ! ");
Console.Write("Введи число: ");

int n;
while (!int.TryParse(Console.ReadLine(), out n))//Проверка вводимого
{
    Console.Beep();//Звуковой сигнал при неправильном вводе
    Console.Write("Неправильный ввод \n" + "Введите число: ");
}

int nn = n;
while (nn / 1000 != 0)
{
    nn = nn / 10;
}
if (n / 100 != 0)
{
    Console.WriteLine("Третья цифра введенного числа" + n + " равна :  " + nn % 10);
}
else
{
    Console.WriteLine("Третьeй цифры в введенном числе " + n + "  нет ");
}