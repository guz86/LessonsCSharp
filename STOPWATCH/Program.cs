using System;
using System.Diagnostics;

namespace STOPWATCH
{
    class Program
    {
        // измерить время выполнения кода
        static void Main(string[] args)
        {
            // создаем объект класса Stopwatch
            var sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < 5000;i++)
            {
                Console.WriteLine("");
            }

            sw.Stop();

            Console.WriteLine($"Time: {sw.ElapsedMilliseconds}");

            
            var sm = new Stopwatch();
            sm.Start();
            System.Threading.Thread.Sleep(100);
            sm.Stop();
            Console.WriteLine($"Time: {sm.ElapsedMilliseconds}");


            sm.Restart(); // reset start
            System.Threading.Thread.Sleep(500);
            sm.Stop();
            Console.WriteLine($"Time: {sm.ElapsedMilliseconds}");
        }
    }
}
