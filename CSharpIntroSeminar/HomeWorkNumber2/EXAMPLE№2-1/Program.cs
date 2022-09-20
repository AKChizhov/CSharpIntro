int Input()
{
Console.Clear();
Console.WriteLine("Ведите число от 100 по 999");
int enter = Convert.ToInt32(Console.ReadLine());
return enter;
}

int n = Input ();

 if (n >=100 && n<=999)
{
int n1 = (n%100 - n% 10)/10;
Console.WriteLine(n1);
}
else 
{
 int n11 = Input();  
 Console.WriteLine(n11);
}

