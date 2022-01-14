using System;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point3D point1 = new Point3D
            //{
            //    X = 1,
            //    Y = 1,
            //    Z = 3
            //};

            Point2D point2 = new Point2D(1,3);
            Point3D point3 = new Point3D(1,2,4);
            point3.Print3D();
        }
    }
}
