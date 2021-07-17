using System;

namespace boxLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("[]");

                }

                Console.WriteLine();
            }
        }
    }
}
