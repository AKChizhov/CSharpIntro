/*
Задача: Написать программу, которая из сформированного массива строк содержащих символы и числа создать массив из строк,
в который попадут только символы, не являющиеця цифрами. Входные данные можно получить путём ввода с клавиатуры,
но лучше сделать автогенерацию данных. При решении не использовать "читерство".
Количество строк в массиве определяется псевдослучайно в интервале с 5 по 15. Количество символов в строке - псевдослучайно
в интервале с 3 по 3. Каждый символ - псевдослучайно в интервале с 48 по 110 (коды клавиш клавиатуры). 
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

string[] ModifArray(string[] array)//Преобразование массива в массив не содержащий цифры
{
    string[] number = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        foreach (char aa in array[i])
        {
            for (int j = 0; j <= 9; j++)
            {
                if (aa == Convert.ToChar(number[j]))
                {
                    array[i] = array[i].Replace(number[j], "");
                }
            }
        }
    }
    return array;
}


int wordsNumber = CreateNumber(5, 16);//Для наглядности на экране
Console.WriteLine("\n\tСоздан массив из "+wordsNumber+" строк (возможно с 5 по 15), в каждой из которых возможно с 3 по 7 символов"+
"\n\tСимволы задаются кодами клавиш клавиатуры с 48 по 110");
string[] ourWordsArray = CreateWordsArray(wordsNumber);
Console.ForegroundColor = ConsoleColor.Red;
ourWordsArray = FillWordsArray(ourWordsArray,3,8);//Для наглядности на экране
PrintArray(ourWordsArray);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\n\tИсходный массив преобразован в массив, не содержащий цифр");
ourWordsArray = ModifArray(ourWordsArray);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(ourWordsArray);
Console.WriteLine();
Console.ReadKey();