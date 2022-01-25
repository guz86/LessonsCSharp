using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceOfInterfaces
{
    // добавляем через наследование метод Fire
    interface ITrowingWeapon : IWeapon
    {
        void Trow();
    }
}
