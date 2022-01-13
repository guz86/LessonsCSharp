using System;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D
            {
                X = 1,
                Y = 1,
                Z = 3
            };

            Point2D point2 = new Point2D(1,3);
            Point2D point3 = new Point3D();
        }
    }
}
