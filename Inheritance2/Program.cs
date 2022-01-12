using System;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person { FirstName = "Danil", LastName = "Bodrov" };
            //person1.PrintFullName();

            Teacher teacher1 = new Teacher { FirstName = "Evgen", LastName = "Petrov" };
            Student student1 = new Student { FirstName = "Sergey", LastName = "Alexeev" };

            Person[] people = { teacher1, student1 };

            PrintPersons(people);


            static void PrintPersons(Person[] people)
            {
                foreach (var person in people)
                {
                    person.PrintFullName();
                }
            }

            // add new item class diogram
        }
    }
}
