using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class SportCar : Car
    {
        public override void Drive()
        {
            //base.Drive();
            Console.WriteLine("Спорткар едет быстро");
        }
    }
}
