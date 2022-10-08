/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
Пример к задаче не полностью соответствует ее условию. Поэтому реализован полный алгоритм прирешении задачи
      - поиск искомого числа в указанных координатах;
      - поиск искомого числа во всем массиве при его отсутствии в указанных кординатах.
Где :
      - findNumber - разыскиваемое число;
      - analizN - предполагаемая строчка;
      - analizM - предполагаемый столбец;
      - ourArray - анализируемый массив;
      - result - запуск расширенного поиска по всему массиву.
*/

int DefenitionArraySize()//Задание размерности массива
{
    int size = new Random().Next(2, 16);
    return size;
}

int[,] CreateArray(int size1, int size2)//Создание массива потребной размерности
{
    return new int[size1, size2];
}

int[,] FillArray(int[,] array, int size1, int size2)//Создание анализируемого массива
{
    int i = 0;
    while (i < size1)
    {
        int y = 0;
        while (y < size2)
        {
            array[i, y] = new Random().Next(-999, 1000);
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
            Console.Write("   " + array[i, y]);
            y++;
        }
        Console.WriteLine();
        i++;
    }
}

int AnalizArrayOurData(int[,] array, int number1, int number2, int findNumber)//Поиск в заданных координатах
{
    int flag = 0;
    if (array[number1 - 1, number2 - 1] == findNumber)
    {
        Console.WriteLine("\n\tДа, указанное число " + findNumber + " находится в " + number1 + " строчке  и в " + number2 + " столбце");
    }
    else
    {
        Console.WriteLine("\n\tНет, в " + number1 + " строчке  и в " + number2 + " столбце находится число : " + array[number1 - 1, number2 - 1]);
        flag++;
    }
    return flag;
}

void AnalizArray(int[,] array, int size1, int size2, int findNumber)//Поиск по всему массиву
{
    int i = 0;
    while (i < size1)
    {
        int y = 0;
        while (y < size2)
        {
            if (array[i, y] == findNumber)
            {
                Console.WriteLine("\n\tРазыскиваемое число  " + findNumber + " в массиве есть, его координаты : х : " + (i + 1) + " , у : " + (y + 1));
                return;
            }
            y++;
        }
        i++;
    }
    Console.WriteLine("\n\tРазыскиваемого числа  " + findNumber + " в массиве нет");
}

Console.Clear();
int n = DefenitionArraySize();//задание количества строчек 
int m = DefenitionArraySize();//задание количества столбцов
Console.WriteLine("\n\tБудет анализироваться массив размерностью " + n + " на " + m);
int[,] ourArray = CreateArray(n, m);
ourArray = FillArray(ourArray, n, m);
PrintArray(ourArray, n, m);
Console.Write("\n\tВведите число, которое будем искать : ");
int analiz = Convert.ToInt32(Console.ReadLine());
Console.Write("\n\tВведите номер строки,где будем  искать : ");
int analizN = Convert.ToInt32(Console.ReadLine());
Console.Write("\n\tВведите номер столбца,где будем  искать : ");
int analizM = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("\n\tИщем число " + analiz + " в массиве " + n + " на " + m +
" :\n\tна позиции строчка " + analizN + " столбец " + analizM + "  :");
Console.WriteLine();
PrintArray(ourArray, n, m);
int result = AnalizArrayOurData(ourArray,analizN,analizM,analiz);
if (result ==1)
{
Console.WriteLine("\n\tБудем искать во всем массиве ...  ");
AnalizArray(ourArray, n, m, analiz);
}
