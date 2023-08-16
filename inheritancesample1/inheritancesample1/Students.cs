using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancesample1
{
    internal class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ContactInformation ContactInformation { get; set; }
        public Department Department { get; set; }
        public Project Project { get; set; }
        public FeesInfo FeesInfo { get; set; }

       
        public void sname()
       
            {
                Console.WriteLine("Hi there, My name is {0} " + Name);
            }
        
        public void fees()
        {
            Console.WriteLine("i am from  " +Department.Name+
                "\tMy firstyear fees is \t" + FeesInfo.FirstYear +
                "\tMy Secondyear fees is \t" + FeesInfo.SecondYear +
                "\t My Thirdyear fees is \t" + FeesInfo.ThirdYear +
                "\t My fourthyear fees is \t" + FeesInfo.FourthYear +".Thankyou");
        }
    }
}
