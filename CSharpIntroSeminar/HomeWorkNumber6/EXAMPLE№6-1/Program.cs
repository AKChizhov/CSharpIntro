/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
Программа сделана немного более универсальная - пользователь вводит не М чисел, а сколько ему надо. Реализован начальный уровень защиты от 
неправильного ввода чисел. Можно в качестве разделения чисел использовать : - пробелы, один или несколько
                                                                            - запятые.
Использована рекурсия - как пример, тема семинара в том числе и рекурсия, ранее мною не использовавшаяся в ДЗ. Хотя к использованию 
рекурсии без крайней надобности отношусь осторожно.
Где :
 --- numbers - массив, введенный пользователем (после преобразования)  
 --- pars - массив, введенный пользователем (как введено) 
*/

int FindPositiv(int[] array, int index, int countPos)//метод определяет количество чисел больше 0.
{
    if (index < 0) return countPos;
    else if (array[index] <= 0) return FindPositiv(array, index - 1, countPos);
    else return FindPositiv(array, index - 1, countPos + 1);
}

void PrintArray(int[] array)//Метод выводит числа в привычном виде.
{
    Console.WriteLine("\n\tВведены числа :");
    foreach (int i in array)
    {
        Console.Write(" " + i);
    }
}

int[] numbers;
int pars;
Console.WriteLine("\n\tВведите числа через пробел(ы),запятые : ");
numbers = Console.ReadLine()!.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.TryParse(i, out pars) ? pars : 0).ToArray();

PrintArray(numbers);
Console.WriteLine("\n\tИз них положительных чисел : " + FindPositiv(numbers, numbers.GetLength(0) - 1, 0) + "\n  ");
