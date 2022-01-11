using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadonly
{
    class MyClass
    {
        // неявно статические
        public const int a = 10;
        public const double PI = 3.14;
        private const string MY_ERROR = "some error";
        public const int MAX_VALUE = 42;




        public MyClass()
        {

        }

        public void Foo()
        {
            Console.WriteLine(MY_ERROR);
        }
    }
}
