/*
*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
Создается массив для чисел находящихся на нечетной позиции с размерностью на 2 больше. Размерности в учебных задачах маленькие, поэтому память
задействуется дополнительно незназначительно. В предпоследний член массива заносится искомое количество, а в последний - их сумма.
Где :
 ---- size - размер анализируемого массива;
 ---- data - анализируемый массив;
 ---- result - массив с членами на нечетной позиции, их количеством и суммой. 
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
        array[i] = new Random().Next(-10, 10);
        i++;
    }
}

void PrintArray(int[] array, int index)//Вывод массива
{
    Console.WriteLine();
    int i = 0;
    while (i < index)
    {
        Console.Write("\t " + array[i]);
        i++;
    }
    Console.WriteLine();
}

int[] Analiz(int[] arrayIn, int[] arrayOut, int index)//Поиск чисел на нечетных позициях, их количества и суммы.
{
    int i = 1;
    int count = 0;
    int summ = 0;
    while (i < index)
    {
        arrayOut[count] = arrayIn[i];
        summ = summ + arrayIn[i];
        count++;
        i = i + 2;
    }
    arrayOut[index] = count;
    arrayOut[index + 1] = summ;
    return arrayOut;
}

int size = GetArraySize(10, 21);
int[] data = CreateArray(size);
Definition(data, size);
Console.WriteLine("\n\tАнализируемый массив чисел :");
PrintArray(data, size);
int[] result = CreateArray(size + 2);
result = Analiz(data, result, size);
Console.WriteLine("\n\tВ анализируемом массиве " + result[size] + " чисел на нечетных позициях. Их сумма " + result[size + 1] + " Это :");
PrintArray(result, result[size]);
