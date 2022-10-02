/* для любознательных: Написать программу премножения любых целых чисел.
 Данная программа использует методы. Число вводится как строка. Число раскладывается в ряд по степеням числа 10 - каждый символ строки-числа (массива 
 символов по сути) умножается на 10 в степени, равной его порядковому номер. После перемножения получается матрица вычисленного числа без сдвига.
 Далее двиг по арифметическим правилам и приведение числа-произведения к нормальному изображению. В завершении произведение из-за размеров приводится 
 к строчному типу.
 Где :
  --- naimed1 и naimed2 - вводимые числа ( при вводе-выводе используются их более удобные названия 'a' и 'b');
  --- indexA и indexB - разрядность вводимых чисел;
  --- indexArrayResult - рязрядность числа-произведения вводимых чисел;
  --- arrayAfterMultipcation - число-произведение вводимых чисел (свертка без смещения);
  --- PrintArray - число-произведение вводимых чисел (свертка со смещением);
  --- с - число-произведение в строком типе ( метод Message - Информация для пользователя).
*/
string InputRequest(string name1)//Ввод числа.
{
    Console.Write("\tВведите очень большое число " + name1 + ": ");
    string name = Console.ReadLine()!;
    Console.WriteLine("\tВведено : " + name);
    return name!;
}

int[] CreateArray(int size)//Создание массива
{
    return new int[size];
}

int ArrayLenght(string name)//Определение разрядности вводимого числа
{
    int indexArray = name!.Length;
    Console.WriteLine("\tРазрядность числа : " + name + " равна " + indexArray);
    return indexArray;
}

void PolynomialArray(string name, int indexArray,string nameNumber)//Разложение введенного числа в ряд по степеням числа 10-для наглядности
{
    int i = 0;
    Console.WriteLine("\tРазложение введенного чисела  "+nameNumber+ "  в ряд по степеням числа 10 :");
    while (i < indexArray)
    {
        Console.Write(name[i] + "x10X" + (indexArray - i - 1) + "+");
        i++;
    }
    Console.WriteLine();
}

int SizeArray(int index1Array, int index2Array, char array1Number0, char array2Number0)//Определение рязрядности числа-произведения
{
    int indexSumm = index1Array + index2Array - 1;
    char temp1a = Convert.ToChar(array1Number0);
    char temp1b = Convert.ToChar(array2Number0);
    int temp1 = (temp1a - '0') * (temp1b - '0');
    if (temp1 / 10 != 0) indexSumm++;
    Console.WriteLine("\tРазрядность числа-произведения двух введенных чисел : " + indexSumm);
    return indexSumm;
}

int[] ArrayMultiplication(int index1Array, int index2Array, int indexSumm, string name1, string name2, int[] arrayResult)//Умножение чисел
{
    int k = 0;
    int j = index2Array - 1;
    while (j >= 0)
    {
        int i = index1Array - 1;
        k = indexSumm - 1 - index2Array + j + 1;
        while (i >= 0)
        {
            char tempora = Convert.ToChar(name1[i]);
            char temporb = Convert.ToChar(name2[j]);
            int tempopar = (tempora - '0') * (temporb - '0');
            arrayResult[k] = tempopar + arrayResult[k];
            i--;
            k--;
        }
        j--;
    }
    return arrayResult;
}

int[] ArrayFinal(int[] arrayIn, int[] arrayOut, int indexSumm)//Приведение результата произведения к стандартному виду
{
    int temp3 = 0;
    int nn = indexSumm - 1;
    while (nn >= 0)
    {
        int rrr = arrayIn[nn] + temp3;
        arrayOut[nn] = rrr % 10;
        temp3 = rrr / 10;
        nn--;
    }
    return arrayOut;
}

void PrintArray(int[] array, int size)//Вывод на экран результата произведения
{
    Console.WriteLine();
    int indexend2 = 0;
    while (indexend2 < size)
    {
        Console.Write("  " + array[indexend2]);
        indexend2++;
    }
}

void Message(string a,string b, int[] array, int index )//Вывод для пользователя и приведения результата к строковому виду.
{
//Console.WriteLine();
Console.WriteLine("\n\n\tИнформация для пользователя");
Console.WriteLine(" \n" + "   Введено число a : " + a + " \n\t и число b : " + b);
int indexend3 = 1;
string c = Convert.ToString(array[0]);
while (indexend3 < index)
{
    c = c + Convert.ToString(array[indexend3]);
    indexend3++;
}
Console.WriteLine("\n\t Их произведение равно : " + c);
}

string naimed1 = InputRequest("a");
string naimed2 = InputRequest("b");
int indexA = ArrayLenght(naimed1);
int indexB = ArrayLenght(naimed2);
PolynomialArray(naimed1, indexA,naimed1);
PolynomialArray(naimed2, indexB,naimed2);
int indexArrayResult = SizeArray(indexA, indexB, naimed1[0], naimed2[0]);
int[] arrayAfterMultipcation = CreateArray(indexArrayResult);
arrayAfterMultipcation = ArrayMultiplication(indexA, indexB, indexArrayResult, naimed1, naimed2, arrayAfterMultipcation);
PrintArray(arrayAfterMultipcation, indexArrayResult);
int[] arrayFinal = CreateArray(indexArrayResult);
arrayFinal = ArrayFinal(arrayAfterMultipcation, arrayFinal, indexArrayResult);
PrintArray(arrayFinal, indexArrayResult);
Message(naimed1,naimed2,arrayFinal,indexArrayResult);
