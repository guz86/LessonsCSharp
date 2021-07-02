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

        }
    }
}
