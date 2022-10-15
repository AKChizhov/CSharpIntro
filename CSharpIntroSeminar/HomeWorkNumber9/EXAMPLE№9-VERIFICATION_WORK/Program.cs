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

int wordsNumber = CreateNumber(5, 16);
string[] ourWordsArray = CreateWordsArray(wordsNumber);