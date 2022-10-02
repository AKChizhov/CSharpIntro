/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
После получения размерности массив создается на размером на 1 больше. В последний элемент массива заносится 
искомая величина.
Где :
 ---- size - размерность анализируемого массива;
 ---- result - анализируемый массив.
*/

int GetArraySize(int min, int max)//Задание размерности массива
{
    return new Random().Next(min, max);
}

double[] CreateArray(int index)//Создание массива 
{
    return new double[index];
}

void Definition(double[] array, int index)//Заполнение массива псевдослучайными числами.
{
    int i = 0;
    double temp = 0;

    while (i < index)
    {
        temp = new Random().Next(-1000, 1000);
        array[i] = temp / 10;
        i++;
    }
}

void PrintArray(double[] array, int index)//Вывод массива
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

double[] MinMax(double[] array, int index)//Вычисление разницы между максимальным и минимальным элементами массива
{
    int i = 1;
    double min = array[0];
    double max = array[0];
    while (i < index)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
        i++;
    }
    array[index] = max - min;
    return array;
}

int size = GetArraySize(10, 21);
double[] data = CreateArray(size + 1);
Definition(data, size);
Console.WriteLine("\n\tАнализируемый массив чисел :");
PrintArray(data, size);
data = MinMax(data, size);
Console.WriteLine("\n\tРазница между максимальным и минимальным элементами массива : " + data[size]);