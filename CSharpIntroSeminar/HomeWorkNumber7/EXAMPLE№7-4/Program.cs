/* Перемножение матриц А [l,m] и B [m,n], итоговая матрица C [l,n]
Где :
 ---- arrayA - первый перемножаемый массив
 ---- arrayB - второй перемножаемый массив
 ---- arrayC - массивб полученный после перемножения
 ---- l - размерность первого массива
 ---- m - размерность второго массива
 ---- n - зазмерность массива-произведения
*/
int CreateSizeArray(int border1, int border2)//Определение размерности массива
{
    return new Random().Next(border1, border2); ;
}

int[,] CreateArray(int size1, int size2)//Создание массива потребной размерности
{
    return new int[size1, size2];
}

int[,] FillArray(int[,] array, int size1, int size2)//Заполнение созанных массивов
{
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, int size1, int size2)//Вывод массивов
{

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            Console.Write("   " + array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationArray(int[,] array1, int[,] array2, int[,] array3, int sizel, int size2, int size3)//Перемножение массивов
{
    
    for (int z = 0; z < sizel; z++)
    {
        for (int v = 0; v < size3; v++)
        {
            array3[z,v]= 0;
            for (int w = 0; w < size2; w++)
            {
                array3[z, v] += array1[z, w] * array2[w, v];
            }
        }
    }
    return array3;
}

void PrintAttention()//Вывод теории
{
Console.WriteLine("\n\tОперация умножения двух матриц выполнима только в том случае, если !!!\n\t"+ 
"число столбцов в первом сомножителе равно числу строк во втором; в этом случае говорят, что матрицы согласованы.\n\t"+
"В частности, умножение всегда выполнимо, если оба сомножителя — квадратные матрицы одного и того же порядка.\n"+
"\n\tДля удобства проверки размерность от 2 по 3 и элементы матриц от 0 по 9");
}

Console.Clear();
int l = CreateSizeArray(2, 4);
int m = CreateSizeArray(2, 4);
int n = CreateSizeArray(2, 4);
int[,] arrayA = CreateArray(l, m);
int[,] arrayB = CreateArray(m, n);
int[,] arrayC = CreateArray(l, n);
arrayA = FillArray(arrayA, l, m);
arrayB = FillArray(arrayB, m, n);
PrintAttention();
Console.WriteLine("\n\tПервая матрица размерности "+l+" на "+m+"\n");
PrintArray(arrayA, l, m);
Console.WriteLine();
Console.WriteLine("\n\tВторая матрица размерности "+m+" на "+n+"\n");
PrintArray(arrayB, m, n);
arrayC = MultiplicationArray(arrayA, arrayB, arrayC, l, m, n);
Console.WriteLine("\n\tРезультат перемножения - матрица размерности "+l+" на "+n+"\n");
PrintArray(arrayC, l, n);