
Console.WriteLine("ENTER ANY CHARACHTER");

char ch=Convert.ToChar(Console.ReadLine());

if(ch=='a'||ch=='A'||ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O'||ch == 'u'|| ch == 'U' )
{
   
    Console.WriteLine("{0} is vowel", ch);
}

else
{
    Console.WriteLine("{0} is not vowel",ch);
}


