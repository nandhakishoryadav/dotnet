//program in C# Sharp to read n number of values in an array and display it in reverse order.

Console.WriteLine("enter the number of elements to store :");
int num1=Convert.ToInt32(Console.ReadLine());
int[] arrval2= new int[10];
Console.WriteLine("enter the values {0} to store :",num1);
for(int i=0;i<num1;i++)
{
    arrval2[i]=Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The reversed values are :");
for (int i=num1-1;i<=0;i--)
{
     Console.WriteLine(arrval2[i]);
}