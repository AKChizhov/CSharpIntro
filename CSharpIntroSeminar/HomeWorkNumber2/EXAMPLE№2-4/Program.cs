Console.Clear();
Console.WriteLine("Здравствуй, пользователь !");

int Input()
{
    Console.Write("Введи число от 2 по 20  " + '\n' + " - размерность массива случайных чисел : ");//Метод для обработки введенного
    int enter;
    Int32.TryParse(Console.ReadLine(), out enter);
    return enter;
}

while (true)
{
    int n = Input();

    if (n >= 2 && n <= 21) //Проверка введенного
    {
        int[] array = new int[n];
        int i = 0;
        float summa = 0;
        while (i < n)
        {
            array[i] = new Random().Next(1, 21);//Заполняем массив и вычисляем сумму всех его членов
            summa = summa + array[i];
            Console.Write(" " + array[i]);
            i++;
        }
        Console.Write('\n' + "Среднее арифметическое чисел выуказанного массива :" + "{0: 0.00}", summa / n);
        Console.Write('\n' + " ");
        break;
    }
    Console.Beep();//Звуковой сигнал при неправильном вводе
}

