Console.Clear();
Console.WriteLine("Здравствуй пользователь ! ");
int Input()
{
    Console.Write("Введи число от 100 по 999 :   ");//Обработка вводимого 
    int enter;
    Int32.TryParse(Console.ReadLine(), out enter);
    return enter;
}

while (true)
{
    int n = Input();

    if (n >= 100 && n <= 999)//Проверка вводимого
    {
        int n1 = (n % 100 - n % 10) / 10;
        Console.WriteLine("Вторая цифра введенного числа :  " + n1);
        break;
    }
    Console.Beep();//Звуковой сигнал при неправильном вводе
}

