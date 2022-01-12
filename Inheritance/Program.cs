using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                FirsName = "Ivan",
                LastName = "Drago"
            };

            person1.PrintFirstName();


            Student student1 = new Student
            {
                FirsName = "Alex",
                LastName = "Robov"
            };

            student1.PrintFirstName();
            student1.Learn();
        }
    }
}
