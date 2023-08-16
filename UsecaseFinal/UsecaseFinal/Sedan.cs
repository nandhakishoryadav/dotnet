using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseFinal
{
    internal class Sedan:Cars
    {
        public int PassangerCapacity { get; set; }
        public int TrunkCapacity { get; set; }

        public override void Display()
        {
            Console.WriteLine(" Display Comfort and Convenience Features");
        }

        public override void Get()
        {
            Console.WriteLine(" Get Fuel Efficiency Rating");
        }
    }
}
