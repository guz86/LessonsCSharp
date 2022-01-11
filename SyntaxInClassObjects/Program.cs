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
            Owner owner1 = new Owner();
            owner1.FirstName = "Ivan";
            owner1.LastName = "Alekseev";
            owner1.Adress = "Kuzminskay 6";

            cat1.Owner = owner1;

            Cat cat2 = new Cat
            {
                Age = 5, 
                Name = "Maks", 
                Owner = new Owner
                {
                    Adress = "Pulkovskoe 8",
                    FirstName = "Gennadiy",
                    LastName = "Frolov"
                }
            };

        }
    }
}
 