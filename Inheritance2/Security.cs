﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Security : Employee
    {
        public void Guard()
        {
            Console.WriteLine("Охраняет");
        }
    }
}
