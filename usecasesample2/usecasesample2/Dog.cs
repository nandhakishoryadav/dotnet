using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecasesample2
{
    internal class Dog:Mamals
    { 
        public string BreedName { get; set; }
        public string Colour { get; set; }
       
        public override void Feature()
        {
            Console.WriteLine(" The Dog can bark.");
        }
    }
}
