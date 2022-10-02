/* для любознательных: Написать программу премножения любых целых чисел.
 Данная программа использует процедуры. Число вводится как строка. Число раскладывается в ряд по степеням числа 10 - каждый символ строки-числа (массива 
 символов по сути) умножается на 10 в степени, равной его порядковому номер. После перемножения получается матрица вычисленного числа без сдвига.
 Далее двиг по арифметическим правилам и приведение числа-произведения к нормальному изображению. В завершении произведение из-за размеров приводится 
 к строчному типу.
 Где :
  --- a и b - вводимые числа ( при вводе-выводе используются их названия 'a' и 'b');
  --- indexA и indexB - разрядность вводимых чисел;
  --- indexSumm - рязрядность числа-произведения вводимых чисел;
  --- result - число-произведение вводимых чисел (свертка без смещения);
  --- resultFinal - число-произведение вводимых чисел (свертка со смещением);
  --- с - число-произведение в строком типе ( метод Message - Информация для пользователя).
*/

Console.Write("\n   Введите очень большое число a : ");//Ввод чисел
string? a = Console.ReadLine();
Console.Write("   Введите очень большое число b : ");
string? b = Console.ReadLine();

int indexA = a!.Length;//определение разрядности вводимых чисел
int indexB = b!.Length;
int i = 0;
int j = 0;

Console.WriteLine();//Разложение введенных чисел в ряд по степеням числа 10
Console.WriteLine("\tРазложение введенных чисел в ряд по степеням числа 10 :\n");
while (i < indexA)
{
    Console.Write(a[i] + "x10X" + (indexA - i - 1) + "+");
    i++;
}
Console.WriteLine();
while (j < indexB)
{
    Console.Write(b[j] + "x10X" + (indexB - j - 1) + "+");
    j++;
}

int indexSumm = indexA + indexB - 1;//Определение разрядности числа-произведения
char temp1a = a[0];
char temp1b = b[0];
int temp1 = (temp1a - '0') * (temp1b - '0');
if (temp1 / 10 != 0) indexSumm++;
int[] result = new int[indexSumm];
Console.WriteLine();
Console.WriteLine("\n\tВывод первых символов введенных чисел и разрядность числа-прозведения введенных чисел\n");
Console.WriteLine(a[0] + "     " + b[0] + "       " + indexSumm);

int k = 0;//произведение вводимых чисел - свертка без смещения
j = indexB - 1;
while (j >= 0)
{
    i = indexA - 1;
    k = indexSumm - 1 - indexB + j + 1;
    while (i >= 0)
    {
        char tempora = a[i];
        char temporb = b[j];
        int tempopar = (tempora - '0') * (temporb - '0');
        result[k] = tempopar + result[k];
        i--;
        k--;
    }
    j--;
}

int[] resultFinal = new int[indexSumm];//Приведение результата к стандартному виду
int temp3 = 0;
int nn = indexSumm - 1;
while (nn >= 0)
{
    int rrr = result[nn] + temp3;
    resultFinal[nn] = rrr % 10;
    temp3 = rrr / 10;
    nn--;
}
Console.WriteLine();//Вывод результата без сдвига
Console.WriteLine("\n\tРазвертка вычесленного произведения без смещения : \n");
int indexend = 0;
while (indexend < indexSumm)
{
    Console.Write(result[indexend] + "     ");
    indexend++;
}

Console.WriteLine();//Вывод результата со сдвигом
Console.WriteLine("\n\tРазвертка вычесленного произведения со  смещением : \n");
int indexend1 = 0;
while (indexend1 < indexSumm)
{
    Console.Write(resultFinal[indexend1] + "     ");
    indexend1++;
}

Console.WriteLine();//Вывод результата в нормальном отображении
Console.WriteLine("\n\tВычесленное произведение  в нормальном отображении : \n");
int indexend2 = 0;
while (indexend2 < indexSumm)
{
    Console.Write(resultFinal[indexend2]);
    indexend2++;
}

Console.WriteLine();//Вывод информации для пользователя и приведения результата к строковому виду
Console.WriteLine("\n\n\tИнформация для пользователя");
Console.WriteLine(" \n" + "   Введено число a : " + a + " \n\t и число b : " + b);
int indexend3 = 1;
string c = Convert.ToString(resultFinal[0]);
while (indexend3 < indexSumm)
{
    c = c + Convert.ToString(resultFinal[indexend3]);
    indexend3++;
}

Console.WriteLine("\n\t Их произведение равно : " + c);
