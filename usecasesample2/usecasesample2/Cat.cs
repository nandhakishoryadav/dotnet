using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecasesample2
{
    internal class Cat:Mamals
    {
        public string Type { get; set; }
        public string Colour { get; set; }

        
        public override void Feature()
        {
            Console.WriteLine(" The Cat can meow.");
        }
    }
}
