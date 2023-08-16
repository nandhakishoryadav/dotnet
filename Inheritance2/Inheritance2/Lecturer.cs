using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Lecturer:Person
    {
        
        public int salary { get; set; }
        public Department dept { get; set; }


        public override void Walk()
        {
            Console.WriteLine("Hi there.My name is {0}.I am Walking",Name);
        }

        public override void Work()
        {
            Console.WriteLine("Hi there.I am Teaching to my students");
        }

        public  void GetSalary()
        {
            Console.WriteLine("Thankyou for the salary");
        }
    }
}
