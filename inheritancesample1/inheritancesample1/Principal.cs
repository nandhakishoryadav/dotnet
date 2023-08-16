using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancesample1
{
    internal class Principal:person
    {
        public double Salary { get; set; }

        

        public  override void Work()
        {
            Console.WriteLine("I am working as Principal");
        }
    }
}
