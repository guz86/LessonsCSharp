using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractСlasses
{
    abstract class Weapon
    {
        public abstract void Fire();
        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }


}
