using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancesample1 
{
    internal abstract class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public  ContactInformation ContactInformation { get; set; }


        public  void MName()
        {
            Console.WriteLine("Hi there, My name is " + Name);
        }
        public abstract void Work();

    }
}
