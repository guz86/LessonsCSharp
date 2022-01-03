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
            // point.Y = 8;
            int x = point.Y;
            //point.Z = 10;
            int t = point.Z;
        }
    }
}
