Console.Clear();
Console.WriteLine("Здравствуй пользователь ! ");
int Input()
{
    Console.Write("Введи число -+ 999 :   ");//Обработка вводимого 
    int enter;
    Int32.TryParse(Console.ReadLine(), out enter);
    return enter;
}

while (true)
{
    int n = Input();

    if (n >= -999 && n <= 999)//Проверка вводимого
    {
        if (n / 100 != 0)
        {
            Console.WriteLine(n+"     -третья  цифра введенного числа :  " + Math.Abs(n % 10));
        }
        else
        {
            Console.WriteLine(n+"     -третьей цифры нет");
        }
        break;
    }
    Console.Beep();//Звуковой сигнал при неправильном вводе
}