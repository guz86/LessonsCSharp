using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель запущен");
        }
        // переопределяем метод
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Машина едет");
        }
    }
}
