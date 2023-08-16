
//Question 1

int[] arrval1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
for (int i = 0; i < arrval1.Length; i++)
{
    Console.WriteLine(arrval1[i]);
}


//Question 2

Console.WriteLine("enter the number of elements to store in array");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrval2 = new int[10];
Console.WriteLine("enter the values {0} to be stored", n);
for (int i = 0; i <= n; i++)
{
    arrval2[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("the reverese order of the values enterdd are");
for (int i = n - 1; i >= 0; i--)
{
    Console.WriteLine(arrval2[i]);
}

Console.WriteLine();


//Question 3

Console.WriteLine("enter the number of elements to store in array");
int x = Convert.ToInt32(Console.ReadLine());
int[] arrval3 = new int[10];
Console.WriteLine("enter the values {0} to be stored", x);
for (int i = 0; i < x; i++)
{
    arrval3[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < x; i++)
{
    sum += arrval3[i];
}

Console.WriteLine("the sum of the number is {0}", sum);



//question4

Console.WriteLine("enter the number of elements to store in array");
int y = Convert.ToInt32(Console.ReadLine());
int[] arrval4 = new int[10];
int[] arrval5= new int[10];

Console.WriteLine("enter the values {0} to be stored", y);
for (int i = 0; i < y; i++)
{
    arrval4[i] = Convert.ToInt32(Console.ReadLine());
}



Console.WriteLine("elements stored in first arry are");
for (int i = 0; i < y; i++)
{
    Console.WriteLine(arrval4[i]);
}

Console.WriteLine("elements stored in second  arry are");
for (int i = 0; i < y; i++)
{
    arrval5[i] = arrval4[i];
    Console.WriteLine(arrval5[i]);
}
