int POW(int x, int y){
    int sum=1;
    for(int i=1;i<=y;i++){
        sum*=x;
    }
   return sum;
}
int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(POW(x,y));
