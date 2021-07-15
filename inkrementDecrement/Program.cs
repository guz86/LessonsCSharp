using System;

namespace inkrementDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            // постфиксная форма инкремента и декремента
            
            Console.WriteLine("a++ "+ a++); 
            Console.WriteLine("a-- " + a--);

            // префиксная форма инкремента и декремента
            Console.WriteLine("++a "+ ++a);
            Console.WriteLine("--a " + --a);

            // приоритет операций
            a = 1;
            // 
            Console.WriteLine("++a * a " + (++a * a));
            a = 1;
            // 
            Console.WriteLine("a++ * a " + (a++ * a));

            // тест

            int g = 2, m = 3, l = 4;
            // 2 + 3 = 5  ++g + ++g
            // 2 + 4 = 6 g++ + ++g
            // Console.WriteLine(g++ + ++g);
            // Console.WriteLine("g++ + g + ++m * --l " + (g++  + ++m * --l));
            //                  2 + 4 * 3 = 12+2 = 15
        }
    }
}
