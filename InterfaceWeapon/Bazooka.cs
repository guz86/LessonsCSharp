using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWeapon
{
    class Bazooka : Weapon
    {
        public override int Damage { get { return 100; } }

        public override void Fire()
        {
            Console.WriteLine("БАААХ");
        }
    }
}
