using UseCase4;

Store storeinfo = new Store()
{
    Name = "GROCERRY",
    Location = "Mangalore"
};

ContactInformation contct1 = new ContactInformation()
{
    Address = "Mangalore",
    EmailAddress = "aarya@gmail,com",
    PhoneNumber = 1234567890
};
ContactInformation contct2 = new ContactInformation()
{
    Address = "Kochi",
    EmailAddress = "aarya@gmail,com",
    PhoneNumber = 1234567890
};
ContactInformation contct3 = new ContactInformation()
{
    Address = "Mangalore",
    EmailAddress = "aarya@gmail,com",
    PhoneNumber = 123456888
};

ShiftTime shift1 = new ShiftTime()
{
    StartDate = "24-10-2022",
    EndDate = "23-02-2023"
};

ShiftTime shift2 = new ShiftTime()
{
    StartDate = "24-10-2022",
    EndDate = "23-02-2023"
};


Manager lec1 = new Manager()
{
    Name = "Aarya",
    Age = 29,
    Gender = "Female",
    Salary=20000,
    Storeinfo = storeinfo,
    contcat=contct1

};


SecurityPerson s1 = new SecurityPerson()
{
    Name = "Binu",
    Age = 44,
    Gender = "male",
    Salary = 15000,
    shiftinfo = shift1,
    contcat = contct2


};

SecurityPerson s2 = new SecurityPerson()
{
    Name = "john",
    Age = 34,
    Gender = "male",
    Salary = 15000,
    shiftinfo = shift2,
    contcat = contct3


};

lec1.Walk();
lec1.Work();
lec1.Supervise();

s1.Walk();
s1.Work();
s1.OpenDoor();


s2.Walk();
s2.Work();
s2.OpenDoor();
