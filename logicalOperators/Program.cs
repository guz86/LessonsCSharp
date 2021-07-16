using System;

namespace logicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isInfected = true;
            int temperature = 36;
            bool isHighTemperature = temperature>=37;
            bool isHeadPain = false;

            //if (!isInfected)
            //{
            // Console.WriteLine("Вы здоровы!");
            // }
            if (isHighTemperature || isHeadPain) {
                Console.WriteLine("Температура: "+ temperature);
                Console.WriteLine("Возможно вы заболели!");
            }
            else
            {
                Console.WriteLine("Вы здоровы!");
            }

        }
    }
}
