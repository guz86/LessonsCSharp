using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class SportCar : Car
    {
        protected override void StartEngine()
        {
            //base.StartEngine();
            Console.WriteLine("Врр...");
        }
        public override void Drive()
        {
            //base.Drive();
            StartEngine();
            Console.WriteLine("Спорткар едет быстро");
        }
    }
}
