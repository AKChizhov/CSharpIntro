/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Вычисляется как среднее арифметическое элементов сток, так и столбцов.
Где :
 --- n - число строк;
 --- m - число столбцов;
 --- ourArray - анализируемый массив.
*/

int FindNumber()//Определение размерности
{
    return new Random().Next(2, 17);
}

int[,] CreateArray(int size1, int size2)//Создание массива определенной размерности
{
    return new int[size1, size2];
}

int[,] FillArray(int[,] array, int size1, int size2)//Заполнение массива числами от -99 по 99
{
    int i = 0;
    while (i < size1)
    {
        int y = 0;
        while (y < size2)
        {
            array[i, y] = new Random().Next(-99, 100);
            y++;
        }
        i++;
    }
    return array;
}

void PrintArray(int[,] array, int size1, int size2)//Вывод массива
{
    int i = 0;
    while (i < size1)
    {
        int y = 0;
        while (y < size2)
        {
            Console.Write("  " + array[i, y]);
            y++;
        }
        Console.WriteLine();
        i++;
    }
}

void PrintSummArrayN(int[,] array, int size1, int size2)//Определение среднего арифметического элементов строк
{
    int i = 0;
    while (i < size1)
    {
        int y = 0;
        double summN = 0;
        while (y < size2)
        {
            summN = summN + array[i, y];
            y++;
        }
        Console.Write("   " + "{0:f2}", (summN / Convert.ToUInt32(size2)));
        i++;
    }
}

void PrintSummArrayM(int[,] array, int size1, int size2)//Определение среднего арифметического элементов столбцов
{
    int y = 0;
    while (y < size2)
    {
        int i = 0;
        double summN = 0;
        while (i < size1)
        {
            summN = summN + array[i, y];
            i++;
        }
        Console.Write("   " + "{0:f2}", (summN / Convert.ToUInt32(size1)));
        y++;
    }
}

int n = FindNumber();
int m = FindNumber();
int[,] ourArray = CreateArray(n, m);
ourArray = FillArray(ourArray, n, m);
Console.Clear();
Console.WriteLine("\n\tАнализируемый массив размерностью " + n + " на " + m + " :\n");
PrintArray(ourArray, n, m);
Console.WriteLine("\n\tСреднее арифметическое элементов " + n + " строк :\n");
PrintSummArrayN(ourArray, n, m);
Console.WriteLine("\n\n\tСреднее арифметическое элементов " + m + " столбцов :\n");
PrintSummArrayM(ourArray, n, m);
Console.WriteLine();
