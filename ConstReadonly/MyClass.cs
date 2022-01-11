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
        public readonly int c = 3;
        public static readonly int d;
        public readonly int f = 55;



        // данные для readonly мы можем получить в конструкторе
        public MyClass(int b)
        {
            this.b = b;
        }
        // статический конструктор который будет вызван только один раз для
        // инициализации статических полей
        static MyClass()
        {
            d = 100;
        }

        public void Foo()
        {

            Console.WriteLine("-----Foo------");
            Console.WriteLine($"MY_ERROR - {MY_ERROR}");
            Console.WriteLine($"a - {a}");
            Console.WriteLine($"b - {b}");
            Console.WriteLine($"c - {c}");
            Console.WriteLine($"d - {d}");
            Console.WriteLine("-----Foo------");
        }
    }
}
