using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iheritance2
{
    internal class Student:Person
    {
        public int RollNO { get; set; }
        public string SemesterName { get; set; }    
        public int Totalmarks { get; set; }
        public Project prj  { get; set; }


        public override void Work()
        {
            Console.WriteLine("Hi there.I am Learning");
        }
        public  void PayFees()
        {
            Console.WriteLine("I am paying fees");
        }
    }
}
