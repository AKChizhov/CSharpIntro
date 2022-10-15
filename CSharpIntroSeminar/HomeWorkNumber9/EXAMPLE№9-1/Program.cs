int[] array = new int[9];
HashSet<int> set = new HashSet<int>();
int i = 0;
while (set.Count < 9)
{
     set.Add(new Random().Next(0,10));     
}

foreach(int c in set)
{
  Console.Write("  "+c); 
 array[i] = c;
    i++;
}
Console.WriteLine();
foreach(int c in array)
{
  Console.Write("  "+c);
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write ("\n\tЧто");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write ("-то\n");
int[] ourArray={65,76,66,56} ;
foreach(int d in ourArray)
{
  Console.Write(Convert.ToChar(d));
}

string[] number ={"0","1","2","3","4","5","6","7","8","9"};
string data= "";
for(int j=48;j<=110;j++) 
{
data = string.Concat(data +Convert.ToChar( j));
}
Console.WriteLine("\n\t"+data);
Console.WriteLine("\t"+data.Length);
int index=0;
foreach(char aa in data)
{
  for(int zzz=0;zzz<=9;zzz++)
  {
  if(aa==Convert.ToChar(number[zzz]))
  {
  data=data.Replace(number[zzz],"");
  }
  }
  index++;
}
Console.WriteLine("\t"+index);
Console.WriteLine("\t"+data);

