using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.publicField); // доступно только на уровне экземпляра класса

            B b = new B();
            Console.WriteLine(b.publicField); // доступно
            b.Foo();
        }
    }
}
