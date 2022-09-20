Console.Clear();
Console.WriteLine("Здравствуй пользователь ! ");
int Input()
{
    Console.WriteLine("Ведите число от 100 по 999");
    int enter; // = Convert.ToInt32(Console.ReadLine());
    Int32.TryParse(Console.ReadLine(), out enter);
    return enter;
}

while (true)
{
    int n = Input();

    if (n >= 100 && n <= 999)
    {
        int n1 = (n % 100 - n % 10) / 10;
        Console.WriteLine(n1);
        break;
    }
}

