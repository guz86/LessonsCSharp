using System;

namespace logicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isInfected = true;
            bool isHighTemperature = true;
            bool isHeadPain = true;

            //if (!isInfected)
            //{
            // Console.WriteLine("Вы здоровы!");
            // }
            if (isHighTemperature && isHeadPain) {
                Console.WriteLine("Возможно вы заболели!");
            }

        }
    }
}
