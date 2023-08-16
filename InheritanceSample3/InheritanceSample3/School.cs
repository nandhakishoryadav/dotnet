using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    internal  class School
    {
        public string Name { get; set; }    
        public int Age { get; set; }    
        public string Address { get; set; } 

        public void Contact()
        {
            Console.WriteLine(" Update contact information");

        }

        
       
    }
}
