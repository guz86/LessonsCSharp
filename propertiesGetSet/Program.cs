using System;

namespace propertiesGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Console.WriteLine(point.GetX());
            point.SetX(15);
            Console.WriteLine(point.GetX());
            //
            point.Y = 4;
            int x = point.Y;
        }
    }
}
