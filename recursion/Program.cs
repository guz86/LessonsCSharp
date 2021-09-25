using System;

namespace recursion
{
    class Program
    {
        static void Foo()
        {
            Console.WriteLine("Foo");
            Foo();
        }
        static void Main(string[] args)
        {
            Foo();
        }
    }
}
