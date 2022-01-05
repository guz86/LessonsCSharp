using System;

namespace staticClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new ClassWithStaticMethod();
            Console.WriteLine(class1.GetType());

            class1.Bar();
            ClassWithStaticMethod.Foo();
            class1.Bar();
        }
    }
}
