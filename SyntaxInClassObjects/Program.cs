using System;

namespace SyntaxInClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();

            cat1.Age = 5;
            cat1.Name = "Boris";

            Cat cat2 = new Cat
            {
                Age = 5, 
                Name = "Maks"
            };

        }
    }
}
 