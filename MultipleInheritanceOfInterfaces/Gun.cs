using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceOfInterfaces
{
    // реализация интерфейса
    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name} - Пышь");
        }
    }
}
