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

string[] FillWordsArray(string[] array)
{
    int wordsNumer = array.Length;
    Console.WriteLine(wordsNumer);
    for (int i = 0; i < wordsNumer; i++)
    {
        int wordsSize = new Random().Next(3, 8);
        array[i] = "";
        for (int j = 0; j < wordsSize; j++)
        {
            int temp =new Random().Next(48,111);
            array[i] = string.Concat(array[i] + Convert.ToChar(temp));
        }
        Console.Write("\t" + array[i]);
    }
    return array;
}


int wordsNumber = CreateNumber(5, 16);
string[] ourWordsArray = CreateWordsArray(wordsNumber);
ourWordsArray=FillWordsArray(ourWordsArray);