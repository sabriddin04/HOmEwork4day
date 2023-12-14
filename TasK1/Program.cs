int n=Convert.ToInt32(Console.ReadLine());
int cnt=0,even=0,odd=0,sum=0;
while(n>0)
{
    if(n%10%2==0){
       even++;
    }
    if(n%10%2!=0){
       odd++;
    }
    sum+=n%10;
    cnt++;
    n=n/10;
    
}
System.Console.WriteLine("Even:"+even);
System.Console.WriteLine("Odd:"+odd);
System.Console.WriteLine("Digit:"+cnt);
System.Console.WriteLine("sum:"+sum);