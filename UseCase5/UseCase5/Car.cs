using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase5
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Engine engineinfo { get; set; }
        public Colour colorinfo { get; set; }

        public void DisplayCarInformation()
        {

            Console.WriteLine("Make :" + Make);
            Console.WriteLine("Model :" + Model);
            Console.WriteLine("Year :" + Year);
            Console.WriteLine("Name :" + colorinfo.Name);
            Console.WriteLine("Code :" + colorinfo.Code);
            Console.WriteLine("Type :" + engineinfo.Type);
            Console.WriteLine("Power :" + engineinfo.Power);
        }



           
            

       
            
}
}
