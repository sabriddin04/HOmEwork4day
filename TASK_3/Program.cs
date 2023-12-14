int n=Convert.ToInt32(Console.ReadLine());

int MIN(int n){
int min=n%10;
while(n>0){
    if(min>n%10){
        min=n%10;

    }
    n=n/10;

}
return min;
}
int MAX(int n){
int max=n%10;
while(n>0){
    if(max<n%10){
        max=n%10;

    }
    n=n/10;

}
return max;
}
System.Console.Write(MIN(n)+"+"+MAX(n)+"="+(MIN(n)+MAX(n)));
