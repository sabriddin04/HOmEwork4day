int n=Convert.ToInt32(Console.ReadLine());
void Div(int n){
    for(int i=1;i<=n;i++){
        if(n%i==0){
            System.Console.Write(i+" ");
        }
    }
}
Div(n);
