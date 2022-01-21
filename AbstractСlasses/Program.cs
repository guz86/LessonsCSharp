using System;

namespace AbstractСlasses
{
    class Program
    {
        static void Main(string[] args)
        {
             Player player = new Player();
            //player.Fire(new Gun());

            Weapon[] weapons = { new Gun(), new MachineGun(), new Bazooka() };

            foreach (var weapon in weapons)
            {
                weapon.ShowInfo();
                player.Fire(weapon);
                Console.WriteLine(weapon.GetType().Name);
            }

        }
    }
}
