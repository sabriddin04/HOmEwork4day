int Min(int val1, int val2){
    if(val1>val2){
        return val2;
    }
    else if(val2>val1){
        return val1;
    }
    return 0;
}
int val1=Convert.ToInt32(Console.ReadLine());
int val2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Min(val1,val2));