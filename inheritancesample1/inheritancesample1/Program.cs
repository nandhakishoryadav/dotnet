using inheritancesample1;

ContactInformation c1 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c2 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "dd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c3 = new ContactInformation
{
    Address = "bangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c4 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c5 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c6 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c7 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c8 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c9 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

ContactInformation c10 = new ContactInformation
{
    Address = "mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = "9874563210"

};

Department d1 = new Department
{
    Name = "COMPUTER SCIENCE AND ENGINEERING",
    Code = "CSE"
};

Department d2 = new Department
{
    Name = "MECHANICHAL ENGINEERING",
    Code = "ME"
};

Department d3 = new Department
{
    Name = "CIVIL ENGINEERING",
    Code = "CV"
};


Project pr1 = new Project
{
    PName="AI",
    Subdate="05-08-2023"
};

Project pr2 = new Project
{
    PName = "IoT",
    Subdate = "05-08-2023"
};

Project pr3 = new Project
{
    PName = "Road Construction",
    Subdate = "05-08-2023"
};

FeesInfo fee1 = new FeesInfo
{
    FirstYear = 115000,
    SecondYear = 105000,
    ThirdYear = 105000,
    FourthYear = 110000
};

FeesInfo fee2 = new FeesInfo
{
    FirstYear = 100000,
    SecondYear = 95000,
    ThirdYear = 90000,
    FourthYear = 90000
};

FeesInfo fee3 = new FeesInfo
{
    FirstYear = 110000,
    SecondYear = 100000,
    ThirdYear = 100000,
    FourthYear = 100000
};




Principal princi = new Principal
{
    Name = "James",
    Age = 54,
    Gender = "male",
    Salary = 50000,
    ContactInformation = c1
};

HeadOfDepartment hod1 = new HeadOfDepartment
{
    Name = "John",
    Age = 44,
    Gender = "male",
    Salary = 40000,
    ContactInformation = c2,
    Department = d1
};

HeadOfDepartment hod2 = new HeadOfDepartment
{
    Name = "Mathew",
    Age = 50,
    Gender = "male",
    Salary = 40000,
    ContactInformation = c3,
    Department = d2
};


HeadOfDepartment hod3 = new HeadOfDepartment
{
    Name = "Akshay",
    Age = 35,
    Gender = "male",
    Salary = 40000,
    ContactInformation = c4,
    Department = d3
};

Lecturer l1 = new Lecturer
{
    Name = "Mary",
    Age = 40,
    Gender = "female",
    Salary = 30000,
    ContactInformation = c5,
    Department = d1,
    ClassName="101"
    
};

Lecturer l2 = new Lecturer
{
    Name = "Anu",
    Age = 30,
    Gender = "female",
    Salary = 30000,
    ContactInformation = c6,
    Department = d2,
    ClassName = "102"

};

Lecturer l3 = new Lecturer
{
    Name = "Arya",
    Age = 30,
    Gender = "female",
    Salary = 30000,
    ContactInformation = c7,
    Department = d3,
    ClassName = "103"

};

Students s1 = new Students
{
    Name = "Arshad",
    Age = 21,
    Gender = "male",
    ContactInformation = c8,
    Department = d1,
    Project = pr1,
    FeesInfo = fee1
};

Students s2 = new Students
{
    Name = "Ajith",
    Age = 20,
    Gender = "male",
    ContactInformation = c9,
    Department = d2,
    Project = pr2,
    FeesInfo = fee2
};


Students s3 = new Students
{
    Name = "Bharath",
    Age = 22,
    Gender = "male",
    ContactInformation = c10,
    Department = d3,
    Project = pr3,
    FeesInfo = fee3
};


princi.MName();
princi.Work();
Console.WriteLine();
hod1.MName();
hod1.Work();
hod1.Hod();
Console.WriteLine();
hod2.MName();
hod2.Work();
hod2.Hod();
Console.WriteLine();
l1.MName(); 
l1.Work();
l1.lec();
Console.WriteLine();
l2.MName();
l2.Work();
l2.lec();
Console.WriteLine();
l3.MName();
l3.Work();
l3.lec();
Console.WriteLine();
s1.sname();
s1.fees();
Console.WriteLine();
s2.sname();
s2.fees();
Console.WriteLine();
s3.sname();
s3.fees();
Console.WriteLine();

