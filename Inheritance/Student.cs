﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine(FirsName + " учится");
        }
    }
}
