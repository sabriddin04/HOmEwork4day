int Max(int val1, int val2){
    if(val1>val2){
        return val1;
    }
    else if(val2>val1){
        return val2;
    }
    return 0;
}
int val1=Convert.ToInt32(Console.ReadLine());
int val2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Max(val1,val2));
