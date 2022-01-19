using System;

namespace as_is
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.X = 1;
            point1.Y = 5;
            point1.Print();

            Console.WriteLine("---------------");

            Object obj = new Point { X = 5, Y = 4 };
            // явное приведение типов
            Point point = (Point)obj;
            point.X = 2;
            point.Print();

            Console.WriteLine("---------------");

            // оператор as

            static void Foo(Object obj)
            {
                Point point2 = obj as Point;
                if (point2 != null)
                {
                    point2.Print();
                }
            }
            Object obj2 = new Point { X = 1, Y = 1 };
            Foo(obj2);
            object obj3 = " ";
            Foo(obj3);

            // оператор is


        }
    }
}
