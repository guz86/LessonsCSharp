using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            currentDateTime.Print();

            DateTime.Now.Print();

            Console.WriteLine(DateTime.Now.IsDayOfWeek(DayOfWeek.Monday));
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Sunday));
        }
    }
}
