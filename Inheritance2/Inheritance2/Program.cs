using Inheritance2;
class program
{
    static void Main (string[] args)
    {

        ContactInformation c1 = new ContactInformation()
        {
            Address = "mangalore",
            EmailAddress = "nkyyy@email.com",
            PhoneNumber = "9787456212"
        };

        Department d1 = new Department()
        {
            Name = "CSE",
            Location = "mangalore"
        };
        Project pr1 = new Project()
        {
            Name = "AI",
            SubmissionDate = "25-10-2022"
        };



        Lecturer l1 = new Lecturer
        {
            Name = "john",
            salary = 10000,
            dept = d1,

        };

        Student s1 = new Student
        {
            Name = "james",
            Age = 20,
            Gender = "male",
            RollNumber = 100,
            SemesterNane = "sevnth",
            TotalMarks = 100,
            projectinfo = pr1
        };

        Student s2 = new Student
        {
            Name = "mary",
            RollNumber = 101,
            SemesterNane = "third",
            TotalMarks = 90,
            projectinfo = pr1
        };


        l1.Walk();
        l1.Work();
        l1.GetSalary();
       
        s1.Walk();
        s1.Work();
        s1.payfees();
        
        s2.Walk();
        s2.Work();
        s2.payfees();
    }

  
}





