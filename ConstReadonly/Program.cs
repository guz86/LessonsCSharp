using System;

namespace ConstReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass.PI);

            //MyClass myClass = new MyClass();
            MyClass myClass = new MyClass(5);
            myClass.Foo();
            // MyClass.c
            Console.WriteLine(myClass.с);
            Console.WriteLine(myClass.b);
        }
    }
}
