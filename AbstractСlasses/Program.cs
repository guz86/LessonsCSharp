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
                player.CheckInfo(weapon);
                player.Fire(weapon);
                Console.WriteLine(weapon.GetType().FullName);
            }

        }
    }
}
