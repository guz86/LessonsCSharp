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

        // не знаем данные до компиляции, а узнаем данные которые нельзя изменять
        // в момент выполнения программы

        // не readonly является неявно статическим
        public readonly int b;
        public readonly int с = 3;



        // данные для readonly мы можем получить в конструкторе
        public MyClass(int b)
        {
            this.b = b;
        }

        public void Foo()
        {
            Console.WriteLine(MY_ERROR);
        }
    }
}
