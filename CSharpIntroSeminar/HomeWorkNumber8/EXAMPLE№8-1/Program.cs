/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Реализован подсчет суммы элементов как строки, так и столбца. Выдается пользователю номер строки/столбца с наибольшей/наименьшей 
суммой и соответствующее значение.
Где :
 --- lineSize - количество строк в массиве;
 --- columnSize - количество столбцов в массиве;
 --- ourArray - анализируемый массив.
*/

int CreateSizeArray(int min, int max)//Определение размерности массива
{
    return new Random().Next(min, max);
}

int[,] CreateArray(int size1, int size2)//Создание массива определенной размерностью
{
    return new int[size1, size2];
}

int[,] FillArray(int[,] array)//Заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);//Для удобства проверки числа от 0 по 9
    return array;
}

void PrintArray(int[,] array)//Вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("  " + array[i, j]);
        }
        Console.WriteLine();
    }
}

void FindMaxMinSummLine(int[,] array)//Определение максимальной и минимальной суммы элементов строк
{
    int lineMax = 0;
    int lineMin = 0;
    int summMax = -2147483648;
    int summMin = 2147483647;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        if (summ > summMax)
        {
            summMax = summ;
            lineMax = i + 1;
        }
        if (summ < summMin)
        {
            summMin = summ;
            lineMin = i + 1;
        }
    }
    Console.WriteLine("\n\tМаксимальная сумма элементов строки : " + summMax + " в " + lineMax + " строчке");
    Console.WriteLine("\n\tМинимальная сумма элементов строки : " + summMin + " в " + lineMin + " строчке");
}

void FindMaxMinSummColumn(int[,] array)//Определение максимальной и минимальной суммы элементов столбцов
{
    int columnMax = 0;
    int columnMin = 0;
    int summMax = -2147483648;
    int summMin = 2147483647;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = summ + array[i, j];
        }
        if (summ > summMax)
        {
            summMax = summ;
            columnMax = j + 1;
        }
        if (summ < summMin)
        {
            summMin = summ;
            columnMin = j + 1;
        }
    }
    Console.WriteLine("\n\tМаксимальная сумма элементов столбца : " + summMax + " в " + columnMax + " столбце");
    Console.WriteLine("\n\tМинимальная сумма элементов столбца : " + summMin + " в " + columnMin + " столбце");
}

int lineSize = CreateSizeArray(2, 7);//Для удобства проверки размерность массива от 2 по 6
int columnSize = CreateSizeArray(2, 7);
int[,] ourArray = CreateArray(lineSize, columnSize);
ourArray = FillArray(ourArray);
Console.Clear();
Console.WriteLine("\n\tАнализируемый массив размерностью строк : " + ourArray.GetLength(0) + " столбцов : " + ourArray.GetLength(1) + "\n");
PrintArray(ourArray);
FindMaxMinSummLine(ourArray);
FindMaxMinSummColumn(ourArray);