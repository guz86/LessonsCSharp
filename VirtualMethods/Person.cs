using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }
}
