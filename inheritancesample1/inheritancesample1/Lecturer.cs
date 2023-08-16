using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancesample1
{
    internal class Lecturer:person
    {
        public double Salary { get; set; }
        public Department Department { get; set; }
        public string ClassName { get; set; }

        
        public override void Work()
        {
            Console.WriteLine("I am working as Lecturer");
        }
        public void lec()
        {
            Console.WriteLine("I am lecturer of " + Department.Name + "Department");
        }
    }
}
