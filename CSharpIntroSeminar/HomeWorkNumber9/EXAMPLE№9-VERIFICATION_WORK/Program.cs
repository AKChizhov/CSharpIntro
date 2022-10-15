/*

*/

int CreateNumber(int min, int max)
{
    return new Random().Next(min, max);
}

string[] CreateWordsArray(int size)
{
    return new string[size];
}

string[] FillWordsArray(string[] array,int min, int max)
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

void PrintArray(string[] array)
{
    int size = array.Length;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write("   " + array[i]);
    }
}

string[] ModifArray(string[] array)
{
    string[] number = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    int index = 0;
    int size = array.GetLength(0);
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
            index++;
        }
    }
    return array;
}


int wordsNumber = CreateNumber(5, 16);
Console.WriteLine("\n\tСоздан массив из "+wordsNumber+" строк (возможно с 5 по 15), в каждой из которых возможно с 3 по 7 символов"+
"\n\tСимволы задаются кодами клавиш клавиатуры с 48 по 110");
string[] ourWordsArray = CreateWordsArray(wordsNumber);
Console.ForegroundColor = ConsoleColor.Red;
ourWordsArray = FillWordsArray(ourWordsArray,3,8);
PrintArray(ourWordsArray);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\n\tИсходный массив преобразован в массив, не содержащий цифр");
ourWordsArray = ModifArray(ourWordsArray);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(ourWordsArray);
Console.WriteLine();