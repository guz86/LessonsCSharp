using System;

namespace InterfaceWeapon
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] weapons = { new Gun(), new MachineGun(), new Bazooka() };

            foreach (var weapon in weapons)
            {
                player.CheckInfo(weapon);
                player.Fire(weapon);
            }
            player.CheckInfo(new Box());
        }
    }
}
