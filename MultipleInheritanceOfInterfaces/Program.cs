using System;

namespace MultipleInheritanceOfInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // множественное наследование интерфейсов
            IWeapon gun = new Gun();
            gun.Fire();
        }
    }
}
