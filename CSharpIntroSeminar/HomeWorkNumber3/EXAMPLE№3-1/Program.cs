/*
Задача 19
Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Программа реализована для любых чисел с проверкой вводимого,где
 --- n - вводимое число
 --- nnn - рязрядность вводимого числа
 --- flag - палиндром (да/нет)
*/


int Start()//Метод проверяющий вводимое
{
    int enter = 1;
    Console.Clear();
    Console.WriteLine("Здравствуй пользователь ! ");
    Console.Write("Введи число c нечетным количеством цифр: ");

    while (!int.TryParse(Console.ReadLine(), out enter))
    {
        Console.Beep();//Звуковой сигнал при неправильном вводе
        Console.Write("Неправильный ввод \n" + "Введи число c нечетным количеством цифр ");
    }
    return enter;
}

int Odd(int size)//Метод определяющий разрядность вводимого числа
{
    int count = 1;
    while (size / 10 != 0)
    {
        size = size / 10;
        count++;
    }
    return count;
}

int Analiz(int result, double count)//Метод определяющий : палиндром - да/нет
{
    int flag = 0;
    int iteration = 1;
    while (iteration <= count / 2)
    {
        int y = Convert.ToInt32(Math.Pow(10, (count - (iteration * 2 - 1))));
        if (result / y != result % 10)
        {
            break;
        }
        else
        {
            result = (result - (result / y) * y) / 10;
        }
        iteration++;
        flag = 1;
    }
    return (flag);
}
int n = 1;
n = Start();
Console.WriteLine("\t\t"+n);
int nnn = Odd(n);
while (nnn % 2 == 0)//проверка на : нечетное количество и провильность ввода цифр
{
    n = Start();
    nnn = Odd(n);
    Console.WriteLine(n);
}
int flag = Analiz(n, nnn);
if (flag == 1)Console.WriteLine("  Введенное число " + n + "  палиндром");
else Console.WriteLine("  Введенное число " + n + "  не палиндром");
