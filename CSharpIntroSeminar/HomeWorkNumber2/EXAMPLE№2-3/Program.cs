Console.Clear();
Console.WriteLine("Здравствуй пользователь ! ");
int Input()
{
    Console.Write("Введи число от 1 по 7 :   ");//Обработка вводимого 
    int enter;
    Int32.TryParse(Console.ReadLine(), out enter);
    return enter;
}

while (true)
{
    int n = Input();

    if (n >= 1 && n <= 7)//Проверка вводимого
    {
        if (n == 6 | n == 7)
        {
            Console.WriteLine(n + "     Сегодня выходной  ");
        }
        else
        {
            Console.WriteLine(n + "     Сегодня работаем   ");
        }
        break;
    }
    Console.Beep();//Звуковой сигнал при неправильном вводе
}
