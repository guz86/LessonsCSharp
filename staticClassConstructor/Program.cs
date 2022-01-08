using System;

namespace staticClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {

            StaticConstructor.Foo();

            StaticConstructor newClass1 = new StaticConstructor();

            var newClass2 = new StaticConstructor();
            var newClass3 = new StaticConstructor(99);
            new StaticConstructor(1);
            new StaticConstructor();
        }
    }
}
