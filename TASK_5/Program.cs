void swap(ref int x, ref int y)
{
x=x+y;
y=x-y;
x=x-y;

}

int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
swap(ref x, ref y);

System.Console.WriteLine("X="+x);
System.Console.WriteLine("Y="+y);