// See https://aka.ms/new-console-template for more information

Task t = new Task(new Action(() => {

while(true)
{
   Console.Beep();
   Console.WriteLine("Press any key to stop it...");
   Thread.Sleep(500);
}
}));
t.Start();
Console.WriteLine("Hello!!!");
Console.ReadKey();