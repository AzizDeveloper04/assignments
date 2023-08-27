int sum=0,cikl=1;
while(cikl<1000)
{
   sum+=cikl;
   cikl+=2;
}
System.Console.WriteLine(sum);

// 2

int n=Convert.ToInt32(Console.ReadLine());
int[] array=new int[n];
for(int i=0;i<n;i++)
{
    System.Console.Write($"array[{i}]=");
    array[i]=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
}
int max=array[0],min=array[0]; 
for(int i=1;i<n;i++)
{
 if(min>array[i]) 
 {
     min=array[i];
 }
 if(max<array[i])
 {
    max=array[i];
 }
}
System.Console.WriteLine($"arraydagi maximal va minimal sonlar kopaytmasi : {max*min}");

// 3
uint x=Convert.ToUInt32(Console.ReadLine());
uint sum1=1;
System.Console.Write($"{x}!");
while(x>=1)
{
    sum1*=x;
    x--;     
}
System.Console.Write($"={sum1}");