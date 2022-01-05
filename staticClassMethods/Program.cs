using System;

namespace staticClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var class1 = new ClassWithStaticMethod();
            //  Console.WriteLine(class1.GetType());

            //  class1.Bar();
            //  ClassWithStaticMethod.Foo();
            //  class1.Bar();

            //  ClassWithStaticMethod._B = 511;
            // Console.WriteLine(ClassWithStaticMethod._B);

            // подсчет количества экземпляров/ пример 
            var counterClass = new ClassWithStaticMethod();
            Console.WriteLine(ClassWithStaticMethod.Counter);
            var counterClass2 = new ClassWithStaticMethod();
            Console.WriteLine(ClassWithStaticMethod.Counter);
            // или через статический метод
            Console.WriteLine(ClassWithStaticMethod.Counter); 
            // или через метод экземпляра класса
            Console.WriteLine(counterClass2.GetObjectCount());
        }
    }
}
