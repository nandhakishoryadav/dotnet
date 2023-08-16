using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Student:Person
    {
         
        public int RollNumber { get; set; }
        public string SemesterNane { get; set; }    
        public int TotalMarks { get; set; }
        public Project projectinfo { get; set; }


        public override void Walk()
        {
            Console.WriteLine("Hi there.My name is {0}.I am Walking", Name);
        }

        public override  void Work()
        {
            Console.WriteLine("I am learning");
        }

        public  void payfees()
        {
            Console.WriteLine("I am paying fess");
        }

    }
}
