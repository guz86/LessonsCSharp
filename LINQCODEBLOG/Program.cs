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
            //  Linq
            var result = from item in collection
                         where item > 5
                         select item;


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // с помощью методов расширения . со стрелочками
            //=> лямбда выражение, - такой что ... условие
            var result2 = collection.Where(item => item > 6);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
