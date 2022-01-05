using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassMethods
{
    class ClassWithStaticMethod
    {
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }

        public void Bar()
        {
            Console.WriteLine("Bar");

        }
    }
}
