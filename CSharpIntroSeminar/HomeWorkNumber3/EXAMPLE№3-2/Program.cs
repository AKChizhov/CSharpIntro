/*Задача 21
Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Программа произвольно расставляет две точки в 3-х или 4-х мерном пространстве.
Где : 
    ---- dimension - мерность пространства;
    ---- distance - искомое расстояние между точками;
*/

int GetValue(int min, int max)//Метод определяет размерность пространства ( сберегая нервы - 3-х или 4-х)
{
    return new Random().Next(min, max);
}

int[] CreateArray(int size)//Метод создает массив под мерность пространства
{
    return new int[size];
}

void Find(int[] array, int dimension)//Метод заполняет массив числами от -10 по 10 (легче проверить)
{
    int i = 0;
    while (i < dimension)
    {
        array[i] = GetValue(-10, 11);
        i++;
    }
}

void Print(int[] array, int dimension)//Метод печатает массив - координаты точки
{
    int i = 0;
    while (i < dimension)
    {
        Console.Write(array[i] + "  ");
        i++;
    }
    Console.WriteLine("\tКоординаты точки в " + dimension + " -х мерном пространстве");
    Console.WriteLine();
}

double FindDistance(int[] array1, int[] array2, int dimension)//Метод вычисляет расстояние между точками
{
    int i = 0;
    double dist = 0;
    double temp = 0;
    while (i < dimension)
    {
        temp = temp + Math.Pow(Convert.ToDouble(array2[i] - array1[i]), 2);
        i++;
    }
    dist = Math.Sqrt(temp);
    Console.WriteLine("\tРасстояние между точками в " + dimension + "-х мерном пространстве равно  " + "{0:f2}", dist);
    return dist;
}

int dimention = GetValue(3, 5);
int[] arrayPointA = CreateArray(dimention);
Find(arrayPointA, dimention);
int[] arrayPointB = CreateArray(dimention);
Find(arrayPointB, dimention);
Print(arrayPointA, dimention);
Print(arrayPointB, dimention);
double distance = FindDistance(arrayPointA, arrayPointB, dimention);
Console.WriteLine("\tНаучились вычислять расстояние в 3-х и 4-мерном пространстве");
