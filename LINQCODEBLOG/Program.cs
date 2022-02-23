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
            Console.WriteLine();


            // группировка


            var groupProduct = products.GroupBy(product => product.Energy);
            // возращает группированные элементы

            foreach (var items in groupProduct)
            {
                Console.WriteLine("items Key " + items.Key);
                foreach (var item in items)
                {
                    Console.WriteLine(item.Energy);
                }
            }
            Console.WriteLine();


            // перевернуть
            products.Reverse();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // all any возвращает bool

            var allProduct = products.All(product => product.Energy == 10);
            Console.WriteLine(allProduct);
            var anyProduct = products.Any(product => product.Energy == 10);
            Console.WriteLine(anyProduct);
            Console.WriteLine();

            // вхождение, принадлежит ли элемент коллекции 
            // проверка по ссылке
            var contrainsFalse = new Product(); // элемент другой коллекции
            var containsProductFalse = products.Contains(contrainsFalse);
            Console.WriteLine(containsProductFalse);
            // products[3] третий элемент нашей коллекции products ы
            var containsProductTrue = products.Contains(products[3]); 
            Console.WriteLine(containsProductTrue);

            // удаление дублирующих элементов из коллекции

            int[] array = new int []{ 1, 2, 3, 2, 1, 3, 2, 1, 35, 6, 4 };
            var unionArray = array.Union(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // Повторяющиеся элементы добавляются в результат только один раз
            foreach (var item in unionArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();


            // найти пересечения множеств, только то что совпадает

            int[] array2 = new int[] { 35, 55 };
            var intersect = array.Intersect(array2);

            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();


            // найти что не пересекается exept

            // Повторяющиеся элементы добавляются в результат только один раз
            var exept = array.Except(array2);
            foreach (var item in exept)
            {
                Console.WriteLine(item);
            }

            // перемножить все элементы между собой
            // последовательно перемножит все элементы между собой
            int aggregate = array.Aggregate((x, y) => x * y);
            Console.WriteLine("\n"+ aggregate);


            // сумма не всех элементов, часть пропустить
            int sumElements = array.Skip(2).Take(3).Sum();
            Console.WriteLine("\n" + sumElements);
            // пропустить первые 2 элемента, и взять 3 элемента и просуммировать


            // операции выбора
            int firstElement = array.First(); // может быть исключение, если массив пустой
            int firstElementDef = array.FirstOrDefault(); // обрабатываем исключение на дефолт
            // выбрать эелемент с конкретным значением
            // если 2 элемента в коллекции то в Single() будет исключение. SingleOrDefault если коллекция пустая
            var productElement = products.SingleOrDefault(product => product.Energy == 500);
            // первый продукт у которого ценность будет равна 100
            var FirstproductElement = products.FirstOrDefault(product => product.Energy == 100);


            // 

        }
    }
}
