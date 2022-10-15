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
    }
    return array;
}
 
void PrintArray(string[] array)
{
    int size=array.Length;
    Console.WriteLine();
    for(int i=0;i<size;i++)
    {
        Console.Write("   "+array[i]);
    }
} 

int wordsNumber = CreateNumber(5, 16);
string[] ourWordsArray = CreateWordsArray(wordsNumber);
ourWordsArray=FillWordsArray(ourWordsArray);
PrintArray(ourWordsArray);