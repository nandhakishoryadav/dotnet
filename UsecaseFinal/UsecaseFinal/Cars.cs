using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseFinal
{
    internal abstract class Cars
    {
        public string Make { get; set; }    
        public String Model { get; set; }
        public int Year { get; set; }

        public void Value()
        {
            Console.WriteLine(" Calculate Estimated Value");
        }

        public void Spec()
        {
            Console.WriteLine(" Display Car Specifications");
        }
        public void Mname()
        {
            Console.WriteLine(" The car is "+Make +" "+ Model);
        }

        public abstract void Display();
        public abstract void Get();
    }
}
