/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
Программа показывает не только количество четных чисел в массиве но и их самих.
Создается массив для заполнения четными числами размерностью на 1 больше анализируемого.Этот массив заполняется четными числами
 и нулями до размерности исходного массива. Последним числом передается искомое количество четных чисел. 
 Где :
 ---- size - размерность анализируемого массива;
 ---- data - анализируемый массив;
 ---- Result - массив с четными числами;
 ---- count - количество четных чисел. 
*/

int GetArraySize(int min, int max)//Задание размерности массива
{
    return new Random().Next(min, max);
}

int[] CreateArray(int index)//Создание массива 
{
    return new int[index];
}

void Definition(int[] array, int index)//Заполнение массива псевдослучайными числами.
{
    int i = 0;
    while (i < index)
    {
        array[i] = new Random().Next(100, 1000);
        i++;
    }
}

void PrintArray(int[] array, int index)//Вывод массива
{
    Console.WriteLine();
    int i = 0;
    while (i < index)
    {
        if (array[i] != 0) Console.Write("\t " + array[i]);
        i++;
    }
    Console.WriteLine();
}

int[] Analiz(int[] arrayIn, int[] arrayOut, int index)//Поиск четных чисел и их количества.
{
    int i = 0;
    int count = 0;
    while (i < index)
    {
        if (arrayIn[i] % 2 == 0)
        {
            arrayOut[count] = arrayIn[i];
            count++;
        }
        i++;
    }
    arrayOut[index] = count;
    return arrayOut;
}


int size = GetArraySize(10, 21);
int[] data = CreateArray(size);
Definition(data, size);
Console.WriteLine("\n\tАнализируемый массив трехзначных чисел :");
PrintArray(data, size);
int[] result = CreateArray(size + 1);
result = Analiz(data, result, size);
Console.WriteLine("\n\tВ анализируемом массиве трехзначных чисел  " + result[size] + " четных чисел. Это :");
PrintArray(result, size);
Console.WriteLine();