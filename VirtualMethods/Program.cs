using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new Car());
            person.Drive(new SportCar());

        }
    }
}
