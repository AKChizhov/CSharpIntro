/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Программа предупреждает о неЕвклидовой геометрии. Начальный уровень защиты от неправильного ввода.
Где :
 --- number - массив коэффициентов линейных уравнений после приведения к обычному виду.
 --- pars - массив коэффициентов линейных уравнений - как введен.
*/

void PrintArray(int[] array)//Метод выводит числа в привычном виде.
{
    Console.WriteLine("\n\tВведены числа :");
    foreach (int i in array)
    {
        Console.Write(" " + i);
    }
}

void PrintArrayModif(int[] array)//Метод представляет уравнения в привычном виде и предупреждает о  неЕвлидовой геометрии (?? в ответах)
{
    int i = 0;
    while (i <= 2)
    {
        Console.WriteLine("\n\tПолучены уравнения y = " + array[i + 1] + " * x + " + array[i]);
        i = i + 2;
    }
    if (array[1]== array[3]) Console.WriteLine("\n\tПересечение в бесконечности. Геометрия Лобачевского !!!");
}

double calculation(int[] array)//Метод решает линейные уравнения
{
    double result = Convert.ToDouble(array[0] - array[2]) / Convert.ToDouble(array[3] - array[1]);
    return result;
}

int[] numbers;
int pars;
Console.WriteLine("\n\tВведите 4 числа - (через пробел(ы),запятые)\n\tзначения b1, k1, b2 и k2 в уравнениях y = k1 * x + b1, y = k2 * x + b2 :\t ");
numbers = Console.ReadLine()!.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.TryParse(i, out pars) ? pars : 0).ToArray();

PrintArray(numbers);
PrintArrayModif(numbers);
Console.WriteLine("\n\tРешение уравнения х = " + calculation(numbers) + " у = " + (calculation(numbers) * numbers[1] + numbers[0]));
Console.WriteLine();

