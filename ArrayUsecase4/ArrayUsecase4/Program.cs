// Write a program in C# Sharp to copy the elements one array into another array

Console.WriteLine("enter the number of values to be stored");
int num3 = Convert.ToInt32(Console.ReadLine());
int[] arrval4 = new int[10];
int[] arrval5 = new int[10];

Console.WriteLine("Enter the values {0} to be stored", num3);
for (int i = 0; i < num3; ++i)
{
    arrval4[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("the values stored in first array is :");
for(int i=0;i < num3;i++)
{
    Console.WriteLine(arrval4[i]);
}

Console.WriteLine("the values stored in second array is :");
for (int i = 0; i < num3; i++)
{
    arrval5[i] = arrval4[i];
    Console.WriteLine(arrval5[i]);
}
