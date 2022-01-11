using System;

namespace ConstReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass.PI);
            
            MyClass myClass = new MyClass();
            myClass.Foo();
        }
    }
}
