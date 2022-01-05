using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassMethods
{
    class ClassWithStaticMethod
    {
        private static int _a;

        public static void Foo()
        {
            Console.WriteLine("Foo");
            _a = 5;
            Console.WriteLine(_a);
        }

        public void Bar()
        {
            Console.WriteLine("Bar");
            _a = 11;
            Console.WriteLine(_a);
            Foo();
        }


        private static int _b;
        // статические свойства
        public static int _B
        {
            get { return _b; }
            set { _b = value; }
        }


    }
}
