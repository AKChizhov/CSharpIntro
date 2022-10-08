/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
Предусмотрено определение размерности массива как автоматически, так и пользователем.
Где :
 ---- n - количество строк
 ---- m - количество столбцов
 ---- concord - ответ пользователя
 ---- ourarray - искомый массив.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int GetSizeArray(int min, int max)//Метод создает псевдослучайно размерность массива
        {
            int size = new Random().Next(min, max);
            return size;
        }

        int UserSizeArray(string text)//Метод создает размерность массива по желанию пользователя
        {
            Console.Write("\n\tВведите количество   " + text + " : ");
            int size = Convert.ToInt32(Console.ReadLine());
            return size;
        }

        double[,] CreateArray(int size1, int size2)//Метод создает массив потребной размерности
        {
            return new double[size1, size2];
        }

        double[,] FillArray(double[,] array, int size1, int size2)//Метод заполняет числами массив. Для упрощения от -1000 до 1000 
        {
            int i = 0;
            while (i <= size1 - 1)
            {
                int y = 0;
                while (y <= size2 - 1)
                {
                    array[i, y] = new Random().NextDouble() * 1500.00 - 500;
                    y++;
                }
                i++;
            }
            return array;
        }

        void PrintArray(double[,] array, int size1, int size2)//Метод выводит массив
        {
            int i = 0;
            while (i <= size1 - 1)
            {
                int y = 0;
                while (y <= size2 - 1)
                {
                    Console.Write("   " + "{0:f1}", array[i, y]);
                    y++;
                }
                Console.WriteLine();
                i++;
            }
        }

        int n = GetSizeArray(1, 10);//Определяем количество строк
        int m = GetSizeArray(1, 10);//Определяем количество столбцов
        Console.WriteLine("\n\tРазмерность создаваемого двумерного массива (по умолчанию от 1 по 9 ) будет : " + n + " на " + m);
        Console.WriteLine("\n\tПодойдет? : да/нет");
        string? concord = Console.ReadLine();
        if (concord == "нет")
        {
            n = UserSizeArray("строк");//Переопределяем количество строк по желанию пользователя
            m = UserSizeArray("столбцов");//Переопределяем количество столбцов по желанию пользователя
        }
        else
        {
            Console.WriteLine("\n\tСпасибо за согласие");
        }
        double[,] ourarray = CreateArray(n, m);
        FillArray(ourarray, n, m);
        Console.WriteLine("\n\tМассив "+n+" на "+m+" , заполненный случайными вещественными числами :\n");
        PrintArray(ourarray, n, m);
        Console.WriteLine();
    }
}
