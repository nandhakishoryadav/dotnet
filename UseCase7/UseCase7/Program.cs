using System.Net.Mail;
using System.Net.Sockets;
using UseCase7;

ContactInformation1 conatct1 = new ContactInformation1()
{
    Address = "StreetNo 1",
    EmailAddress = "John@email.com",
    PhoneNumber= "9876543210"
};
ContactInformation1 conatct2 = new ContactInformation1()
{
    Address = "StreetNo 2",
    EmailAddress = "Mary@email.com",
    PhoneNumber = "7896541230"
};

Department1 Departmentinfo1 = new Department1()
{
    Name = "COMPUTER SCIENCE",
    Location = "Mangalore"
};

Department1 Departmentinfo2 = new Department1()
{
    Name = "INFORMATION SCIENCE",
    Location = "Mangalore"
};

Teacher teacher1 = new Teacher()
{
    Name="John",
    Age=24,
    Gender="Male",
    Salary=20000,
    Contact=conatct1,
    Departmentinfo=Departmentinfo1
};

Teacher teacher2 = new Teacher()
{
    Name = "Mary",
    Age = 34,
    Gender = "Female",
    Salary = 28000,
    Contact = conatct2,
    Departmentinfo = Departmentinfo2

};
