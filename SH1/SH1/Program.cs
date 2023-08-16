public class Library
{
    public string BookName { get; set; }
    public int BookId { get; set; }    
    public string AuthorName { get; set; }  
    public BookRegInformation BookInfo { get; set; }





    public void DisplayStudentInformation()
    {
        Console.WriteLine("Name: "+ BookName);
        Console.WriteLine("BookId: " + BookId);
        Console.WriteLine("AuthorName: " +AuthorName);
        Console.WriteLine("BookRegInformation :");
        Console.WriteLine("Date issued: " + BookInfo.DateIssue);
        Console.WriteLine("Bookprice: " + BookInfo.price);
    }

}



public class BookRegInformation
{
    public string DateIssue { get; set; }
    public int price { get; set; }

}

class program
{
    static void Main (string[] args)
    {
        BookRegInformation BookInfo1 = new BookRegInformation
        {
            DateIssue = "10-10-2021",
            price = 2000
       
        };

        BookRegInformation BookInfo2 = new BookRegInformation
        {
            DateIssue = "12-10-2021",
            price = 2500

        };

        BookRegInformation BookInfo3 = new BookRegInformation
        {
            DateIssue = "09-08-2021",
            price = 1500

        };




        Library library1 = new Library()
        {
            BookName="STORY",
            BookId=100,
            AuthorName="JAMES",
            BookInfo=BookInfo1
            

        };

        Library library2= new Library()
        {
            BookName = "SONGS",
            BookId = 200,
            AuthorName = "MATHEW",
            BookInfo = BookInfo2


        };

        Library library3 = new Library()
        {
            BookName = "COMICS",
            BookId = 300,
            AuthorName = "JOHN",
            BookInfo = BookInfo3


        };
        library1.DisplayStudentInformation();
        Console.WriteLine();
        library2.DisplayStudentInformation();
        Console.WriteLine();
        library3.DisplayStudentInformation();
    }
}