﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class A
    {
        public int publicField;
        private int privateField;
        protected int protectedField;

        protected void Foo()
        {

        }

        protected int MyProperty { get; set; }

        public A()
        {
            Console.WriteLine(publicField);
            Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
        }
    }
}
