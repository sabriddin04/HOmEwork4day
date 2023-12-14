int[] arr=new int[]{1,2,3};

int n=Convert.ToInt32(Console.ReadLine());



void mas(ref int[] arr,int n){

for (int i = 0; i < arr.Length; i++)
{
    arr[i]=arr[i]+n;
}

}

mas( ref arr,n);

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i]+" ");
}
