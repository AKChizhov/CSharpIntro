/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
Реализован вывод 3-х мерного массива для наглядности вертикальными слоями. Массив заполнен с помощью вспомогательного массива 
неповторяющимися псевдослучайными числами.
Где :
 --- lineSize - количество строк;
 --- columnSize - количество столбцов;
 --- layerSize - количество слоев (глубина);
 --- ourHelpArray - 1- вспомогательный мерный массив размерностью равной произведению кол-ва строк,столбцов,слоев 3-х мерного 
 --- ourArray - искомый 3-х мерный массив.
*/

int CreateSizeArray(int min, int max)//Определение размеров массива
{
    return new Random().Next(min, max);
}

int[] CreateHelpArray(int size1, int size2, int size3)//Создание вспомогательного одномерного массива -линейная развертка 3-х мерного
{
    return new int[size1 * size2 * size3];
}

int[,,] CreateArray(int size1, int size2, int size3)//Создание 3-х мерного массива
{
    return new int[size1, size2, size3];
}

int[] FillHelpArray(int[] array)//Заполнение и вывод 1-но мерного массива неповторяющимися псевдослучайными числами для 3-х мерного массива
{
    int iSize = array.GetLength(0);
    int k = 0; ;
    int temp = 0;
    int flagIter = 0;
    Console.WriteLine("\n\tМассив из " + iSize + " неповторяющихся чисел для заполнения 3-х мерного массива\n");
    while (k < iSize)
    {
        int flag = 0;
        temp = new Random().Next(10, 99);
        for (int i = 0; i <= k; i++)
        {
            if (array[i] == temp)
            {
                flagIter++;
                flag++;
            }
        }
        if (flag == 0)
        {
            array[k] = temp;
            Console.Write(" " + array[k]);
            k++;
        }
    }
    Console.WriteLine("\n\n\tОбработано попыток заполнения массива повторяющимися числами : " + flagIter);
    return array;
}

int[,,] FillArray(int[,,] array, int[] array1)//Заполнение 3-х мерного массива числами из одномерного
{
    int z = 0;
    int iSize = array.GetLength(0);
    int jSize = array.GetLength(1);
    int kSize = array.GetLength(2);
    for (int i = 0; i < iSize; i++)
    {
        for (int j = 0; j < jSize; j++)
        {
            for (int k = 0; k < kSize; k++)
            {
                array[i, j, k] = array1[z];
                z++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)//Вывод 3-х мерного массива вертикальными (для наглядности) слоями элементами с координатами
{
    int iSize = array.GetLength(0);
    int jSize = array.GetLength(1);
    int kSize = array.GetLength(2);
    for (int k = kSize - 1; k >= 0; k--)
    {
        Console.WriteLine("\n\tСлой " + (k + 1) + "-й массива ( " + iSize + " на " + jSize + " на " + kSize + " )\n");
        for (int i = 0; i < iSize; i++)
        {
            for (int j = 0; j < jSize; j++)
            {
                Console.Write("  " + array[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
            Console.WriteLine();
        }
    }
}

int lineSize = CreateSizeArray(3, 4);//Для удобства проверки и наглядности размерность массива одинакова и однозначно равна 3
int columnSize = CreateSizeArray(3, 4);// --- || ---
int layerSize = CreateSizeArray(3, 4);// --- || ---
int[] ourHelpArray = CreateHelpArray(lineSize, columnSize, layerSize);
int[,,] ourArray = CreateArray(lineSize, columnSize, layerSize);
ourHelpArray = FillHelpArray(ourHelpArray);
ourArray = FillArray(ourArray, ourHelpArray);
PrintArray(ourArray);