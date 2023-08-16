using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseFinal
{
    internal class SportsCar:Cars
    {
        public string EngineSize { get; set; }
        public int TopSpeed { get; set; }

        public override void Display()
        {
            Console.WriteLine(" Display Racing Performance Stats");
        }

        public override void Get()
        {
            Console.WriteLine(" Get Recommended Upgrades");
        }
    }
}
