﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace as_is
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X\t{X}");
            Console.WriteLine($"Y\t{Y}");
        }
    }
}
