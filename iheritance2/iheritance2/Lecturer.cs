using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iheritance2
{
    internal class Lecturer:Person
    {
        public Department dept { get; set; }    
        public int salary { get; set; }

        public override void Work()
        {
            Console.WriteLine("Hi there I am teaching");

        }
        public  void GetSalary()
        {
            Console.WriteLine("Thankyou for the salary");

        }
    }
}
