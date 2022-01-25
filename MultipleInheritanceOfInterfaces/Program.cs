using System;

namespace MultipleInheritanceOfInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // множественное наследование интерфейсов
            //IWeapon gun = new Gun();
            //gun.Fire();
            Player player = new Player();
            player.Fire(new Gun());

            player.Trow(new Knife());
        }
    }
}
