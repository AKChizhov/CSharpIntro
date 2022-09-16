Console.WriteLine("Введите число a   :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b   :");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine("Максимальное число max = "+ a );
    Console.WriteLine("Минимальное число min = "+ b );
}    
else 
{
Console.WriteLine("Максимальное число max = "+ b );
Console.WriteLine("Минимальное число min = "+ a );
}
