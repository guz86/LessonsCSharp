using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceOfInterfaces
{
    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
    }
}
