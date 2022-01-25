using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceOfInterfaces
{
    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name} - Пышь");
        }
    }
}
