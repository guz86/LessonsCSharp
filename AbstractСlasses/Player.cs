using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractСlasses
{
    //class Player
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }
}
