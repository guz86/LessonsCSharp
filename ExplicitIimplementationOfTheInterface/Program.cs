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
            myClass.Action();
            Foo(myClass);
            Baa(myClass);
            MyOtherClass myOtherClass = new MyOtherClass();
            //myOtherClass.Action(); - неоднозначность
            Foo(myOtherClass);
            Baa(myOtherClass);

            // ссылка с типом интерфейса у которой класс который реализует данный интерфейс
            ISecondInterface secondInterface = new MyOtherClass();
            secondInterface.Action();

            Console.WriteLine();

            // приведение объекта к необходимому типу данных

            ((IFirstInterface)myOtherClass).Action();
            ((ISecondInterface)myOtherClass).Action();

            Console.WriteLine();

            // лучший вариант через операторы as или is

            if (myOtherClass is IFirstInterface firstInterface)
            {
                firstInterface.Action();
            }


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
