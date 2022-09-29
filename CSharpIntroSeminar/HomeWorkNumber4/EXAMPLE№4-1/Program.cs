/*
Есть магазин "Еда"
В магазине есть охранник
Охранник ведёт запись всех, кто заходит в магазин
Охранник ведёт запись всех, кто выходит из магазин
Зайти и выйти можно в целый час.
Выяснить в какой промежуток времени было больше всего
посетителей
Данные вводятся парами: приход-уход
Максимум 100 покупателей
Входные данные
10-12
11-13
9-12
Ответ
11-12
!!! Сделал ДЗ как понял : масимум 100 покупателей; время работы с 8 по 23 (устно преподаватель); анализ каждый час.
Где:
 ---- maxInTime - индекс максимального элемента массива. 
 ---- resultPeople - общее количество покупателей за день.
 ---- shop - массив с количеством покупателей по часам за день.
*/

int[] CreateArrayInt(int size)//Метод объявляет массив.(15 время работы магазина:с 8 по 23)
{
    return new int[size];
}
 
int FillArray(int[] array)//Метод заполняет массив псевдослучайными числами (от 0 по 100),определяя максимальный элемент и его инднкс
{
    int temp = 0;
    int maxInTime = -1;
    int i = 0;
    while (i < 15)
    {
        array[i] = new Random().Next(0, 101);
        if (temp < array[i])
        {
            temp = array[i];
            maxInTime = i;
        }
        i++;
    }
    return (maxInTime);
}

int SummaPeaple(int[] array)//Метод определяет сумму членов массива.
{
    int summa = 0;
    int i = 0;
    while (i < 15)
    {
        summa = summa + array[i];
        i++;
    }
    return summa;
}

void PrintArray(int[] array1,int peapleInDay)//Метод выводит на экран запрашиваемую информацию.
{
    Console.WriteLine();
    int i = 0;
    while (i < 15)
    {
        double temp = Convert.ToDouble(array1[i])/peapleInDay;
        Console.WriteLine("\tС "+(i + 8) + "час.по " + (i + 9) + "час.в магазине было покупателей " + array1[i] + " ,это от пришедших за день "+"{0:P1}",temp);
        i++;
    }
    Console.WriteLine();
}

int[] shop = CreateArrayInt(15);
int maxInTime = FillArray(shop);
int resultPeople = SummaPeaple(shop);
PrintArray(shop,resultPeople);
Console.WriteLine("\tМаксимальное количество покупателей ( " + shop[maxInTime] + " ) из " +resultPeople+" пришедших за день было с " +
 (maxInTime + 8) + " час. по " + (maxInTime + 9) + " час.");
Console.WriteLine();


