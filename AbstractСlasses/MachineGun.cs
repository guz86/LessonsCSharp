using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractСlasses
{
    class MachineGun : Weapon
    {
        public override int Damage => 44;

        public override void Fire()
        {
            Console.WriteLine("Тра та та та та");
        }
    }
}
