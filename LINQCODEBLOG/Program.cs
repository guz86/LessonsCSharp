using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQCODEBLOG
{
    class Program
    {
        static void Main(string[] args)
        {
            // данные из бд, коллекции, наборы данных
            List<int> collection = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                collection.Add(i); 
            }

            var result = from item in collection
                         where item > 5
                         select item;


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
