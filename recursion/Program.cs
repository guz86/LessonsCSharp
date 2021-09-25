using System;

namespace recursion
{
    class Program
    {
        static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i >= 3)
            {
                return;
            }

            i++;
            Foo(i);
        }




        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }


        }

        static Item InitItem()
        {
            return new Item
            {
                Value = 5,
                Child = new Item
                {
                    Value = 4,
                    Child = new Item
                    {
                        Value = 2
                    }
                }
            };
        }

        static void Print(Item item)
        {

           

            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }

            
        }

        static void Main(string[] args)
        {
            // Foo(0);
            Item item = InitItem();
            // Print(item);

            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }




    }



}
