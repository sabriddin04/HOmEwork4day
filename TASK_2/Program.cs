
int ADD(int a, int b){
    return a+b;

}
int Subtract(int a, int b){
    return a-b;

}
int Multiplay(int a, int b){
    return a*b;

}
int Division(int a, int b){
    return a/b;

}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ADD:"+ADD(a,b));
System.Console.WriteLine("Subtract:"+Subtract(a,b));
System.Console.WriteLine("Multiplay:"+Multiplay(a,b));
System.Console.WriteLine("Division:"+Division(a,b));