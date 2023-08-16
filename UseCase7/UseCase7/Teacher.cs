using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase7
{
    internal class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Department1 Departmentinfo { get; set; }
        public ContactInformation1 Contact { get; set; }

        public void DisplayTeacherInformation()
        {
            Console.WriteLine("Name" + Name);
            Console.WriteLine("Age" + Age);
            Console.WriteLine("Gender" + Gender);
            Console.WriteLine("Salary" + Salary);
            Console.WriteLine("Name" + Departmentinfo.Name);
            Console.WriteLine("Location" + Departmentinfo.Location);
            Console.WriteLine("Address" + Contact.Address);
            Console.WriteLine("EmailAddress" + Contact.EmailAddress);
            Console.WriteLine("PhoneNumber" + Contact.PhoneNumber);
        }


           
    }
}
