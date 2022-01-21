using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractСlasses
{
    class Gun : Weapon
    {
        public override int Damage => 10;

        public override void Fire()
        {
            Console.WriteLine("Пыщь");
        }
    }
}
