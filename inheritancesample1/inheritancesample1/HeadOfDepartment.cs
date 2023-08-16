using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancesample1
{
    internal class HeadOfDepartment:person

    {
        public double Salary { get; set; }
        public Department Department { get; set; }

        
        public override void Work()
        {
            Console.WriteLine("I am working as HOD");
        }
        public  void Hod()
        {
            Console.WriteLine("I am HOD of "+Department.Name+"Department");
        }
    }
}
