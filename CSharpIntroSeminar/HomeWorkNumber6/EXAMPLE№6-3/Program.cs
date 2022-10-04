/*
Условия задачи придумал сам себе. Цель была научиться ( и не бояться !) работать с двумерными массивами забыв об их 
одномерной сути. Это последняя работа в VS 2019, сейчас установил 2022. Перенес файл в VSCode. Так как версия новая 
появилась проверка на 'null'. 
Отмечу более удобный комментарий методов в VS.
В "точке входа в программу" оставил процедуры создания исходного массива и пользовательского интерфейса, работа с 
массивом через методы.
Для наглядности вывода на экран и облегчения проверки размерность 5 на 5 и числа до 10.
Где :
 --- members - массив 5 на 5, заполненный псевдо случайными числами;
 --- Writing1 .... Writing6 - методы обрабатывающие команды пользователя.
 --- default - обработка неправильного ввода пользователя;
*/
using System;

namespace SelfMaidTask
{
    class Program
    {
        public static int j1;
        /// <summary>
        /// Метод для вывода исходного массива.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="members"></param>
        static void Writing1(int[,] arr, int[,] members)
        { Console.WriteLine($"Исходный массив");
            for (int i = 0; i < members.GetLength(0); i++)
            {
                for (int j = 0; j < members.GetLength(1); j++)
                {                 
                    Console.Write($"{ members[i, j]}\t");
                }
                Console.WriteLine($"");
            }
        }
        /// <summary>
        /// Метод для вывода диагонали слева направо вниз.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="members"></param>
        static void Writing2(int[,] arr, int[,] members)
        {
            Console.WriteLine($"Диагональ слева направо вниз");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{ members[i, j]}\t");
                    }
                }
            }
            Console.WriteLine($"");
        }
        /// <summary>
        /// Метод для вывода диагонали справа налево вверх.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="members"></param>
        static void Writing3(int[,] arr, int[,] members)
        {
            Console.WriteLine($"Диагональ справа налево вверх");
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 5; j++)
                {
                    j1 = 4 - j;
                    if (i == j)
                    {
                        Console.Write($"{ members[i, j]}\t");
                    }
                }
            }
            Console.WriteLine($"");
            
        }
        /// <summary>
        /// Метод для вывода диагонали слева направо вверх.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="members"></param>
        static void Writing4(int[,] arr, int[,] members)
        {
            Console.WriteLine($"Диагональ слева направо вверх");
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 5; j++)
                {
                    j1 = 4 - j;
                    if (i == j1)
                    {
                        Console.Write($"{ members[i, j]}\t");
                    }
                }
            }
            Console.WriteLine($"");
        }
        /// <summary>
        /// Метод для вывода диагонали справа налево вниз.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="members"></param>
        static void Writing5(int[,] arr, int[,] members)
        {
            Console.WriteLine($"Диагональ справа налево вниз");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    j1 = 4 - j;
                    if (i == j)
                    {
                        Console.Write($"{ members[i, j1]}\t");
                    }
                }
            }
            Console.WriteLine($"");
        }
        /// <summary>
        /// Метод для вывода реверсного массива.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="members"></param>
        static void Writing6(int[,] arr, int[,] members)
        {
            Console.WriteLine($"Реверс исходного массива");
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 4; j >= 0; j--)
                {
                    Console.Write($"{ members[i, j]}\t");
                }
                Console.WriteLine($"");
            }
            Console.WriteLine($"");
        }
         /// <summary>
         /// Точка входа в программу.
         /// </summary>
         /// <param name="args"></param>
        private static void Main(string[] args)

        {
            bool f = true;
            int[,] members = new int[5, 5];
            Random r = new Random();
            {             
                for (int i = 0; i < members.GetLength(0); i++)
                {
                    for (int j = 0; j < members.GetLength(1); j++)
                    {
                        members[i, j] = r.Next(0, 100);                        
                    }                
                }
            }

            while (f)
            { 
            Console.WriteLine("=================================");
            Console.WriteLine("1 - ИСХОДНЫЙ МАССИВ");
            Console.WriteLine("2 - Диагональ слева направо вниз");
            Console.WriteLine("3 - Диагональ справа налево вверх");
            Console.WriteLine("4 - Диагональ слева направо вверх");
            Console.WriteLine("5 - Диагональ справа налево вниз");
            Console.WriteLine("6 - Реверс исходного массива");
            Console.WriteLine("0 - ЗАВЕРШЕНИЕ РАБОТЫ");
            Console.WriteLine("=================================");

            Console.Write("Введите номер метода вывода:   ");
            int writingNumber = int.Parse(Console.ReadLine()!);
                         
                switch (writingNumber)
                {
                    case 0:
                        f = false;
                        Console.Write("Завершение работы   ");
                        break;
                    case 1:
                        Writing1(new int[10, 10], members);
                        break;
                    case 2:
                        Writing2(new int[10, 10], members);
                        break;
                    case 3:
                        Writing3(new int[10, 10], members);
                        break;
                    case 4:
                        Writing4(new int[10, 10], members);
                        break;
                    case 5:
                        Writing5(new int[10, 10], members);
                        break;
                    case 6:
                        Writing6(new int[10, 10], members);
                        break;
                    default:
                        Console.WriteLine("Введен неправильный номер метода .\nВведите снова :   ");
                        break;
                }
            }
           
        }

    }
}
