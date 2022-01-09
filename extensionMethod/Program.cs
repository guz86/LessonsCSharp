using System;

namespace extensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            currentDateTime.Print();

            DateTime.Now.Print();
        }
    }
}
