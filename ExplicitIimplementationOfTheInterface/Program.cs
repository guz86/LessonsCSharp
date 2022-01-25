using System;

namespace ExplicitIimplementationOfTheInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // явная реализация интерфейсов

            //  может ли класс реализовать два интерфейса у которых объявлено 2 одинаковых метода

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
