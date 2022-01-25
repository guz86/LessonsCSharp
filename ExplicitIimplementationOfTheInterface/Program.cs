using System;

namespace ExplicitIimplementationOfTheInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // явная реализация интерфейсов

            //  может ли класс реализовать два интерфейса у которых объявлено 2 одинаковых метода
            MyClass myClass = new MyClass();
            Foo(myClass);
            Baa(myClass);
            MyOtherClass myOtherClass = new MyOtherClass();
            Foo(myOtherClass);
            Baa(myOtherClass);

        }

        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        static void Baa(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}
