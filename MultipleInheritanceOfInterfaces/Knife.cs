using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceOfInterfaces
{
    class Knife : ITrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name} - Хыщь");
        }

        public void Trow()
        {
            Console.WriteLine($"{GetType().Name} - Фьють");
        }
    }
}
