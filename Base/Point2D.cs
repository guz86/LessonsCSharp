﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Point2D
    {
        public Point2D()
        {
            Console.WriteLine("Вызван конструктор класса Point2D");
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
