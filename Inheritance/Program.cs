using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintFullName(Person person)
            {
                Console.WriteLine(person.FirsName + person.LastName );
            }

            Person person1 = new Person
            {
                FirsName = "Ivan",
                LastName = "Drago"
            };

            person1.PrintFirstName();
            PrintFullName(person1);

            Student student1 = new Student
            {
                FirsName = "Alex",
                LastName = "Robov"
            };

            student1.PrintFirstName();
            student1.Learn();

            // person2 может работать только со своими собственными методами
            // методы наследника Student ему не доступны
            Person person2 = new Student
            {
                FirsName = "Oleg",
                LastName = "Romanov"
            };

            PrintFullName(student1);

            
        }
    }
}
