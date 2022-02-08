﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    struct Point : IPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"{X}, {Y}");
        }
    }
}
