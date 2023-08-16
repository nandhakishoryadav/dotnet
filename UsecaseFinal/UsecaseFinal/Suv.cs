using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseFinal
{
    internal class Suv:Cars
    {
        public int TowingCapacity { get; set; }
        public int GroundClearance { get; set; }

        public override void Display()
        {
            Console.WriteLine(" Display Off-Road Performance Stats");
        }

        public override void Get()
        {
            Console.WriteLine(" Get Recommended Towing Accessories");
        }
    }
}
