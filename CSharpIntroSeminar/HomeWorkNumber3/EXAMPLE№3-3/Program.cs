/*
Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
Доработано для ввода произвольных числа и его степени. Проверка ввода.
Где :
     ---- number - вводимое число
     ---- degree - степень в которую будем возводить введенное число.
*/

int Start()//Метод проверяющий число
{
    int enter = 1;
    Console.Clear();
    Console.WriteLine("\t\tЗдравствуй пользователь !\n"+"сначала вводим число, а затем степень в которую будем его возводить");
    Console.Write("Введи число : ");

    while (!int.TryParse(Console.ReadLine(), out enter))
    {
        Console.Beep();//Звуковой сигнал при неправильном вводе
        Console.Write("Неправильный ввод \n" + "Введи число : ");
    }
    return enter;
}

int[] CreateArray(int n, int degree)//Метод  создающий массив заданного размера (n)
{
    Console.WriteLine("   Введено число : "+n+"  его будем возводить в степень :"+degree);
    return new int[n];
}

void Find(int[] array, int n,int degree)//Метод заполняющий массив введенной степени чисел от 1 по n
{
    int i = 0;
    double temp = 0;
    double x = i+1;
    double y = Convert.ToDouble(degree);
    while (i < n)
    {
         temp = Math.Pow(x,y);
         array[i]= Convert.ToInt32( temp);
         x++;
        i++;
    }
}

void Print(int[] array, int n, int degree)
{
    int i = 0;
    while (i < n)
    {
        Console.WriteLine("   число " + (i + 1) + "   в степени  " +degree+" равно  " + array[i]);
        i++;
    }
    Console.WriteLine("\n");
}

int number = Start();
int degree = Start();
int[] massiv = CreateArray(number,degree);
Find(massiv, number,degree);
Print(massiv, number,degree);



