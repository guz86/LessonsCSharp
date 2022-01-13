using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Point3D : Point2D
    {
        public Point3D() :base(4,6)
        {
            Console.WriteLine("Вызван конструктор класса Point3D");
        }
        public int Z { get; set; }
    }
}
