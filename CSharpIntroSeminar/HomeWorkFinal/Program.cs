/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк длиною не более 3-х символов. Первоначальный  
массив можно ввести с клавиатуры, либо задать задать на старте выполнения алгоритма.
Описание: Используется автогенерация. Строки содержащат символы и числа.Количество строк в массиве определяется псевдослучайно в интервале 
с 5 по 20. Количество символов в строке - псевдослучайно в интервале с 1 по 15. Каждый символ - псевдослучайно в интервале с 48 по 110 (коды
клавиш клавиатуры). 
Где :
 --- wordsNumber - число строк в массиве;
 --- ourWordsArray -искомый массив ;
*/

int CreateNumber(int min, int max)//Определение количества строк в массиве
{
    return new Random().Next(min, max);
}

string[] CreateWordsArray(int size)//Создание массива определенной размерности;
{
    return new string[size];
}

string[] FillWordsArray(string[] array,int min, int max)//Заполнение массива символами, в том числе и цифрами;
{
    int wordsNumer = array.Length;
    for (int i = 0; i < wordsNumer; i++)
    {
        int wordsSize = new Random().Next(min, max);
        array[i] = "";
        for (int j = 0; j < wordsSize; j++)
        {
            int temp = new Random().Next(48, 111);
            array[i] = string.Concat(array[i] + Convert.ToChar(temp));
        }
    }
    return array;
}

void PrintArray(string[] array)//вывод массива
{
    int size = array.Length;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write("   " + array[i]);
    }
}


int wordsNumber = CreateNumber(5, 16);//Для наглядности на экране
Console.WriteLine("\n\tСоздан массив из "+wordsNumber+" строк ( с 5 по 15 для наглядности), в каждой из которых возможно с 1 по 21 символов"+
"\n\tСимволы задаются кодами клавиш клавиатуры с 48 по 110");
string[] ourWordsArray = CreateWordsArray(wordsNumber);
Console.ForegroundColor = ConsoleColor.Red;
ourWordsArray = FillWordsArray(ourWordsArray,3,8);//Для наглядности на экране
PrintArray(ourWordsArray);
Console.ForegroundColor = ConsoleColor.White;