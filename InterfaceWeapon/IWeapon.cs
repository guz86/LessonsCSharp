using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWeapon
{
    interface IWeapon
    {
        int Damage { get; }
        void Fire();
    }
}
