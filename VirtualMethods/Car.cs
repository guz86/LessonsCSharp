using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Car
    {
        // переопределяем метод
        public virtual void Drive()
        {
            Console.WriteLine("Машина едет");
        }
    }
}
