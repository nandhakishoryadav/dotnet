using UsecaseInheritance;

ContactInformation c1 = new ContactInformation
{
    Address = "Mangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = 897456321
};

ContactInformation c2 = new ContactInformation
{
    Address = "Bangalore",
    EmailAddress = "abcd@email.com",
    PhoneNumber = 897456321
};

ContactInformation c3 = new ContactInformation
{
    Address = "Pune",
    EmailAddress = "abcd@email.com",
    PhoneNumber = 897456321
};

Store store1 = new Store
{
    Name = "Friuts",
    Location = "Mangalore"
};

ShiftTime shift1 = new ShiftTime
{
    StartDate = "24-10-2021",
    EndDate = "05-08-2022"
};

Manager m1 = new Manager
{
    Name = "John",
    Age = 48,
    Gender = "Male",
    salary = 20000,
    contact = c1,
    storeinfo = store1,
};

SecurityPerson s1 = new SecurityPerson
{
    Name = "James",
    Age = 50,
    Gender = "Male",
    salary = 15000,
    contact = c2,
    shift=shift1
};

SecurityPerson s2 = new SecurityPerson
{
    Name = "Mary",
    Age = 40,
    Gender = "Female",
    salary = 15000,
    contact = c3,
    shift = shift1
};

m1.Walk();
m1.Work();
m1.Supervise();

s1.Walk();  
s1.Work();
s1.OpenDoor();

s2.Walk();
s2.Work();
s2.OpenDoor();

