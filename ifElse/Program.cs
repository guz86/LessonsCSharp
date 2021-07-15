using System;
using System.Threading.Tasks;
using System.Threading;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInfected;
            Random rand = new Random();
            
            // isInfected = rand.Next(0, 2) == 0;

            if (rand.Next(0, 2) == 0)
            {
                Console.WriteLine("Вы подхватили инфекцию!");
            }
            else
            {
                Console.WriteLine("Вы здоровы!");
            }
        }
    }
}
