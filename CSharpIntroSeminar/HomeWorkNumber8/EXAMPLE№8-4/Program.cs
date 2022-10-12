/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7
Реализован алгоритм заполнения массива как четной, так и нечетной размерности спирально последовательно возрастающими числами 
Где :
 --- sizeArray - размерность массива (квадратной матрицы);
 --- iteraz - количество проходов для заполнения массива;
 --- ourArray - искомый массив.
*/

int CreateSizeArray(int min, int max)//Задается размерность массива
{
    return new Random().Next(min, max);
}

int[,] CreateArray(int size)//Создание потребного массива
{
    return new int[size, size];
}

int FindMaxCorretSize(int size)//определение необходимого количества проходов для заполнения массива
{
    int maxTemp = size;
    int maxCorrectSize = 0;
    maxCorrectSize = maxTemp / 2;
    if (maxTemp % 2 != 0)
    {
        maxCorrectSize++;
    }
    return maxCorrectSize;
}

int[,] FillArray(int[,] array, int maxCorrectSize)//Заполнение искомого массива заданным способом
{
    int k = 10;
    int correctSize = 0;
    int size = array.GetLength(0);
    while (correctSize < maxCorrectSize)
    {
        for (int j = 0 + correctSize; j < size - correctSize; j++)
        {
            array[0 + correctSize, j] = k;
            k++;
        }
        for (int i = 1 + correctSize; i < (size - 1 - correctSize); i++)
        {
            array[i, size - correctSize - 1] = k;
            k++;
        }
        for (int j = size - correctSize - 1; j >= 0 + correctSize; j--)
        {
            array[size - 1 - correctSize, j] = k;
            k++;
        }
        for (int i = size - 2 - correctSize; i > 0 + correctSize; i--)
        {
            array[i, 0 + correctSize] = k;
            k++;
        }
        correctSize++;
    }
    if (size % 2 != 0)
    {
        array[(size / 2), (size / 2)] = k - 2;
    }
    return array;
}

void PrintArray(int[,] array)//Вывод искомого массива
{
    int size = array.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write("   " + array[i, j]);
        }
        Console.WriteLine();
    }
}

int sizeArray = CreateSizeArray(4, 10);
int[,] ourArray = CreateArray(sizeArray);
int iteraz = FindMaxCorretSize(sizeArray);
Console.WriteLine();
Console.WriteLine("\n\nМассив (" + sizeArray + "x" + sizeArray + "),заполненный спирально последовательно "+
"возрастающими 2-значными (для наглядности) числами\n");
ourArray = FillArray(ourArray, iteraz);
PrintArray(ourArray);