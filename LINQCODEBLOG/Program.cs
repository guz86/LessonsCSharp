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



            // классы

            //List<Product> products = new List<Product>();
            Random rand = new Random();
            List<Product> products = new List<Product>();
            for (int i = 1; i <= 10; i++)
            {
                
                Product product = new Product()
                {
                    Name = "product:" + i,
                    Energy = rand.Next(10, 12) 
                };
                products.Add(product);
            }

            foreach (var product in products)
            {
                //Console.WriteLine(product.Name+"\t"+product.Energy);
                Console.WriteLine(product);
            }

            var productEnergyMore500 = from product in products
                                       where product.Energy > 500
                                       orderby product.Energy
                                       select product;

            Console.WriteLine("\nProduct more then 500 Energy(orderby)\n");
            foreach (var product in productEnergyMore500)
            {
                Console.WriteLine(product);
            }
            // с помощью методов расширения

            var productEnergyMore500800Method = products.Where(product => product.Energy > 500
            && product.Energy < 800);
            Console.WriteLine("\nProduct more then 500 Energy and less than 800\n");
            foreach (var product in productEnergyMore500800Method)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            // преобразование одного типа в другой
            // из списка продуктов, список Energy
            var selectProducts = from product in products
                                 select product.Energy;
            Console.WriteLine(products);
            Console.WriteLine(selectProducts);

            var selectProductsMethod = products.Select(product => product.Energy);

            foreach (var item in selectProducts)
            {
                Console.WriteLine(item);
            }

            foreach (var item in selectProductsMethod)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // orderby 

            var orderProduct = products.OrderBy(product => product.Energy)
                .ThenBy(product => product.Name);

            foreach (var item in orderProduct)
            {
                Console.WriteLine(item);
            }

//Name: product: 1  Energy: 10
//Name: product: 7  Energy: 10
//Name: product: 9  Energy: 10
//Name: product: 10 Energy: 11 тут по первой цифре в строке
//Name: product: 2  Energy: 11
//Name: product: 3  Energy: 11
//Name: product: 4  Energy: 11
//Name: product: 5  Energy: 11
//Name: product: 6  Energy: 11
//Name: product: 8  Energy: 11


            // группировка


        }
    }
}
