
int[] array = new int[9];
HashSet<int> set = new HashSet<int>();
int i = 0;
while (set.Count < 9)
{
     set.Add(new Random().Next(0,10));
    
    
}


/*var myEnum = array.GetEnumerator() ;
while(myEnum.MoveNext())
{
  Console.WriteLine(myEnum.Current);
}*/

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
