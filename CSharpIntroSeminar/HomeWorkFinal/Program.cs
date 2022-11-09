/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк длиною не более 3-х символов. Первоначальный  
массив можно ввести с клавиатуры, либо задать задать на старте выполнения алгоритма.
Описание: Используется автогенерация. Строки содержащат символы и числа.Количество строк в массиве определяется псевдослучайно в интервале 
с 5 по 15. Количество символов в строке - псевдослучайно в интервале с 1 по 10. Каждый символ - псевдослучайно в интервале с 48 по 110 (коды
клавиш клавиатуры). 
Где :
 --- wordsNumber - число строк в массиве;
 --- ourWordsArray -исходный массив ;
 --- ourCount - число строк длиною не больше 3-х символов;
 --- ourModifWordsArray - массив со строками длиной не более 3-х символов.
*/

int CreateNumber(int min, int max)//Определение количества строк в массиве
{
    return new Random().Next(min, max);
}

string[] CreateWordsArray(int size)//Создание массива определенной размерности;
{
    return new string[size];
}

string[] FillWordsArray(string[] array, int min, int max)//Заполнение массива символами, в том числе и цифрами;
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

int CountMinThan4(string[] array)//Определение количества строк длиною не больше 3-х символов
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillModifWordsArray(string[] arrayIn, string[] arrayOut, int sizeOut)//Заполнение массива строками длиной от 1 по 3 символа
{
    int j = 0;
    int size = arrayIn.Length;
    for (int i = 0; i < size; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[j] = arrayIn[i];
            j++;
        }
    }
    return arrayOut;
}

int wordsNumber = CreateNumber(5, 16);//Для наглядности на экране
Console.Clear();
Console.WriteLine("\n\tСоздан массив из " + wordsNumber + " строк (их может быть от 5 по 15 для наглядности),в каждой может быть от 1 по 10 символ" +
"\n\tСимволы задаются кодами клавиш клавиатуры с 48 по 110 - автогенерацией.");
string[] ourWordsArray = CreateWordsArray(wordsNumber);
Console.ForegroundColor = ConsoleColor.Red;
ourWordsArray = FillWordsArray(ourWordsArray, 1, 11);//Для наглядности на экране
PrintArray(ourWordsArray);
Console.ForegroundColor = ConsoleColor.White;
int ourCount = CountMinThan4(ourWordsArray);
Console.WriteLine("\n\n\tСоздан массив из " + ourCount + " строк исходного массива. Длина строки не больше 3-х символов.");
Console.ForegroundColor = ConsoleColor.Green;
string[] ourModifWordsArray = CreateWordsArray(ourCount);
ourModifWordsArray = FillModifWordsArray(ourWordsArray, ourModifWordsArray, ourCount);
PrintArray(ourModifWordsArray);
Console.WriteLine();
