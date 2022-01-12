using System;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { FirstName = "Danil", LastName = "Bodrov" };
            person1.PrintFullName();
        }
    }
}
