using iheritance2;
class program
{
    static void Main(string[] args)
    {
        ContactInformation c1 = new ContactInformation()
        {
            Address = "mangalore",
            EmailAddress = "abcd@email.com",
            PhoneNumber = "5555555555"
        };
        ContactInformation c2 = new ContactInformation()
        {
            Address = "bangalore",
            EmailAddress = "abcd@email.com",
            PhoneNumber = "666655555"
        };

        Department d1 = new Department()
        {
            Name = "cse",
            Location = "mangalore"
        };

        Project pr = new Project()
        {
            Name = "ai",
            SubmissionDate = "25-10-2022"
        };

        Student s1 = new Student()
        {
            Name = "james",
            Age = 15,
            Gender = "male",
            conatct = c1,
            RollNO = 1,
            Totalmarks = 98,
            prj = pr
        };

        Student s2 = new Student()
        {
            Name = "John",
            Age = 15,
            Gender = "male",
            conatct = c1,
            RollNO = 2,
            Totalmarks = 98,
            prj = pr
        };

        Lecturer l1 = new Lecturer()
        {
            Name = "mary",
            Age = 35,
            Gender = "female",
            conatct = c2,
            dept = d1,
            salary = 10000
        };


        l1.Walk();
        l1.Work();
        l1.GetSalary();
        Console.WriteLine();
        s1.Walk();
        s1.Work();
        s1.PayFees();
        Console.WriteLine();
        s2.Walk();
        s2.Work();
        s2.PayFees();
    }
}
