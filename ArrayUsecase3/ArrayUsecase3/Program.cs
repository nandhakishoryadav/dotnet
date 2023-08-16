Console.WriteLine("enter the number of values to be stored");
int num2=Convert.ToInt32(Console.ReadLine());
int[] arrval3= new int[10];

Console.WriteLine("Enter the values {0} to be stored", num2);
for(int i=0;i<num2;++i)
{
    arrval3[i]= Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
for(int i=0;i<num2;i++)
{
    sum += arrval3[i];
}

Console.WriteLine("The sum is {0}", sum);
